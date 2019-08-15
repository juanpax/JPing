using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

/*
 * Add label saying number of fail or successful attempts 
 * To develop: Include functionality to send UDP traffic  https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.udpclient?view=netframework-4.8 create a demo too 
 * Funcionallity to capture all the packet information Check this: https://stackoverflow.com/questions/1863564/how-to-capture-http-packet-with-sharppcap and https://www.codeproject.com/Articles/12458/SharpPcap-A-Packet-Capture-Framework-for-NET could be a good idea to create a demo first
 * In the future would be good idea to be able to select if you want to capture only the failures (select what kind of failures) or everything, so basically would generate a .pcap and you read the file from Netmon or wireshark
 */

namespace JPing
{
    public partial class Form : System.Windows.Forms.Form
    {
        private bool StartThread = false;
        private List<long> TimeAverageList = new List<long>();

        /* Variables to control the timer */
        public bool tick = false;
        long currentMinutes = 0;

        public Form()
        {
            InitializeComponent();
            Size = new Size(Size.Width, Size.Height - 80);
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);

            ValidateRadioButtons();
            EnableDisableElements(true, false);
        }

        // Method to start the pinging process 
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ResetLabels();
                EnableDisableElements(false, false);
                RemoveJPingFile();
                WriteLogRecord("Started");

                string timeMethod =
                        (radioButtonTimeDoNotStop.Checked) ? "Do not stop" :
                        (radioButtonNumberOfPings.Checked) ? "Number of pings" :
                        (radioButtonMinutes.Checked) ? "Minutes" : "";

                DelegateMethod pingMethod =
                    (radioButtonICMP.Checked) ? new DelegateMethod(SendICMPTraffic) :
                    (radioButtonTCP.Checked) ? new DelegateMethod(SendTCPTraffic) : null;

                string IP = textBoxIP.Text.Trim();
                StartThread = true;

                switch (timeMethod)
                {
                    case "Do not stop":
                        {
                            new Thread(() =>
                            {
                                while (StartThread)
                                {
                                    pingMethod.Invoke(IP);
                                    Thread.Sleep(1000);
                                }
                            }).Start();
                            return;
                        }
                    case "Number of pings":
                        {
                            long numberOfPings = long.Parse(textBoxCustomTime.Text);
                            labelCounter.Visible = true;

                            new Thread(() =>
                            {
                                while (StartThread && numberOfPings > 0)
                                {
                                    pingMethod.Invoke(IP);
                                    Thread.Sleep(1000);

                                    labelCounter.Invoke(new Action(() => labelCounter.Text = (long.Parse(labelCounter.Text) + 1).ToString()));
                                    numberOfPings--;
                                }
                                StopMethod(true);
                            }).Start();
                            return;
                        }
                    case "Minutes":
                        {
                            long minutes = long.Parse(textBoxCustomTime.Text);
                            labelTimer.Visible = true;
                            timer.Enabled = true;

                            new Thread(() =>
                            {
                                while (StartThread && currentMinutes < minutes)
                                {
                                    pingMethod.Invoke(IP);
                                    Thread.Sleep(1000);
                                }
                                StopMethod(true);
                            }).Start();
                            return;
                        }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the required information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to reset the Labels text
        private void ResetLabels()
        {
            labelTimer.Text = "00:00";
            labelTimer.Visible = false;
            labelCounter.Text = "0";
            labelCounter.Visible = false;
            labelStopped.Visible = false;
            labelStarted.Visible = true;
            labelMinimun.Text = "0";
            labelMaximun.Text = "0";
            labelTimeAverage.Text = "0";
        }

        // Method to stop the pinging process
        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopMethod(false);
        }

        // Method when the user stops the process or it finished
        public void StopMethod(bool differentThread)
        {
            StartThread = false;
            timer.Enabled = false;

            if (differentThread)
            {
                labelTimer.Invoke(new Action(() => labelTimer.Visible = false));
                labelCounter.Invoke(new Action(() => labelCounter.Visible = false));
                labelStarted.Invoke(new Action(() => labelStarted.Visible = false));
                labelStopped.Invoke(new Action(() => labelStopped.Visible = false));
            }
            else
            {
                labelTimer.Visible = false;
                labelCounter.Visible = false;
                labelStarted.Visible = false;
                labelStopped.Visible = false;
            }

            EnableDisableElements(true, differentThread);
            ProcessTimeValues(differentThread);
            WriteLogRecord("Stoped");
        }

        // Method to validate the successful traffic stats 
        private void ProcessTimeValues(bool differentThread)
        {
            if (TimeAverageList.Count > 0)
            {
                long MinimunTime = TimeAverageList[0];
                long MaximunTime = TimeAverageList[0];

                long total = 0;

                foreach (long time in TimeAverageList)
                {
                    total += time;

                    if (time < MinimunTime)
                    {
                        MinimunTime = time;
                    }
                    else if (time > MaximunTime)
                    {
                        MaximunTime = time;
                    }
                }

                if (differentThread)
                {
                    labelMinimun.Invoke(new Action(() => labelMinimun.Text = MinimunTime.ToString() + "ms"));
                    labelMaximun.Invoke(new Action(() => labelMaximun.Text = MaximunTime.ToString() + "ms"));
                    labelTimeAverage.Invoke(new Action(() => labelTimeAverage.Text = (total / TimeAverageList.Count).ToString() + "ms"));
                }
                else
                {
                    labelMinimun.Text = MinimunTime.ToString() + "ms";
                    labelMaximun.Text = MaximunTime.ToString() + "ms";
                    labelTimeAverage.Text = (total / TimeAverageList.Count).ToString() + "ms";
                }                

                TimeAverageList.Clear();
            }
        }

        // Method to enable or disable the view components depending if the program is running or not
        private void EnableDisableElements(bool state, bool differentThread)
        {
            if (differentThread)
            {
                textBoxIP.Invoke(new Action(() => textBoxIP.Enabled = state));
                panelTime.Invoke(new Action(() => panelTime.Enabled = state));
                panelTimeOptions.Invoke(new Action(() => panelTimeOptions.Enabled = state));
                panelProtocols.Invoke(new Action(() => panelProtocols.Enabled = state));
                panelProtocolOptions.Invoke(new Action(() => panelProtocolOptions.Enabled = state));
                buttonSelectFileLocation.Invoke(new Action(() => buttonSelectFileLocation.Enabled = state));
                buttonStart.Invoke(new Action(() => buttonStart.Enabled = state));
                buttonStop.Invoke(new Action(() => buttonStop.Enabled = !state));
            }
            else
            {
                textBoxIP.Enabled = state;
                panelTime.Enabled = state;
                panelTimeOptions.Enabled = state;
                panelProtocols.Enabled = state;
                panelProtocolOptions.Enabled = state;
                buttonSelectFileLocation.Enabled = state;
                buttonStart.Enabled = state;
                buttonStop.Enabled = !state;
            }
            buttonStart.BackColor = (state) ? Color.MediumSeaGreen : Color.Gray;
            buttonStop.BackColor = (!state) ? Color.Brown : Color.Gray;
        }

        // Method to validate the form before starting the pinging process
        public bool ValidateForm()
        {
            return (
                !string.IsNullOrEmpty(textBoxIP.Text.Trim()) &&
                (radioButtonTimeDoNotStop.Checked || (radioButtonCustomTime.Checked && !string.IsNullOrEmpty(textBoxCustomTime.Text.Trim()))) &&
                buttonSelectFileLocation.Text.Trim() != "Select log location..." &&
                    (
                        (radioButtonICMP.Checked && (radioButtonICMPDefault.Checked || (radioButtonICMPCustom.Checked && !string.IsNullOrEmpty(textBoxBytes.Text.Trim()) && !string.IsNullOrEmpty(textBoxTimeout.Text.Trim())))) ||
                        (radioButtonTCP.Checked && !string.IsNullOrEmpty(textBoxPort.Text.Trim()))
                    )
                );
        }

        // Method to delete the JPing.txt 
        private void RemoveJPingFile()
        {
            if (File.Exists(buttonSelectFileLocation.Text.Trim()))
            {
                File.Delete(buttonSelectFileLocation.Text.Trim());
            }
        }

        // Method to write a record in the JPing.txt log
        private void WriteLogRecord(string message)
        {
            try
            {
                string text = DateTime.UtcNow.ToString() + " | " + message + "\n";
                File.AppendAllText(buttonSelectFileLocation.Text.Trim(), text);
            }
            catch (Exception ex)
            {
                StartThread = false;
                EnableDisableElements(true, false);
                ProcessTimeValues(false);
                labelError.Text = "There was an error when writing into the JPingLog.txt";
            }
        }

        // Delegate method, this method is going to work for ICM, TCP and UDP and it is only one method declaration
        public delegate void DelegateMethod(string IP);

        // Method to send ICMP traffic 
        public void SendICMPTraffic(string IP)
        {
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = null;

                if (radioButtonICMPCustom.Checked)
                {
                    int bytes = int.Parse(textBoxBytes.Text.Trim());
                    bytes = (bytes >= 28) ? bytes - 28 : bytes;
                    int timeout = int.Parse(textBoxTimeout.Text.Trim());
                    byte[] packet = new byte[bytes];

                    reply = pinger.Send(IP, timeout, packet);
                }
                else
                {
                    reply = pinger.Send(IP);
                }

                if (reply.Status == IPStatus.Success)
                {
                    TimeAverageList.Add(reply.RoundtripTime);
                }
                else
                {
                    WriteLogRecord(string.Format("Ping {0} returned: {1}", IP, reply.Status.ToString()));
                }
            }
            catch (Exception ex)
            {
                WriteLogRecord("Internal error: " + ex.Message);
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }
        }

        // Method to send TCP traffic 
        private void SendTCPTraffic(string IP)
        {
            int port = int.Parse(textBoxPort.Text.Trim());

            try
            {
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                sock.Connect(IP, port);
                stopWatch.Stop();
                TimeAverageList.Add(stopWatch.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                WriteLogRecord(string.Format("TCPPing {0}:{1} returned: {2}", IP, port, ex.Message));
            }
        }

        // Method to display the file chooser when clicking the Select log location button
        private void buttonSelectFileLocation_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string path = fbd.SelectedPath + "\\JPingLog.txt";

                    buttonSelectFileLocation.Text = "      " + path;
                    toolTip.SetToolTip(buttonSelectFileLocation, path);
                }
            }
        }

        // Method to display or not the Port textBox based on the selected protocol 
        private void ValidateRadioButtons()
        {
            ValidateTimeRadioButtons();
            ValidateProtocolRadioButtons();
        }

        private void ValidateProtocolRadioButtons()
        {
            panelICMPOptions.Visible = radioButtonICMP.Checked;
            panelPort.Visible = radioButtonTCP.Checked;
        }

        // This method is shared by the two radioButtons
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            ValidateProtocolRadioButtons();
            ValidateICMPOptionsRadioButtons();
        }

        // Event to be able only to type numbers 
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        // Event when the ICMP radio buttons checked status chanched 
        private void radioButtonICMPOptions_CheckedChanged(object sender, EventArgs e)
        {
            ValidateICMPOptionsRadioButtons();
        }

        // Method to validate the ICMP Radio buttons
        private void ValidateICMPOptionsRadioButtons()
        {
            // This method is configured in this way, so sometimes will not be necessary to decrease or increase the window size
            if ((radioButtonICMPDefault.Checked || radioButtonTCP.Checked) && (panelICMPTimeout.Visible || panelBytes.Visible))
            {
                panelICMPTimeout.Visible = false;
                panelBytes.Visible = false;
                Size = new Size(Size.Width, Size.Height - 56);
            }
            if (radioButtonICMP.Checked && radioButtonICMPCustom.Checked)
            {
                panelICMPTimeout.Visible = true;
                panelBytes.Visible = true;
                Size = new Size(Size.Width, Size.Height + 56);
            }
        }

        // Event when the do not stop option change
        private void radioButtonTimeDoNotStop_CheckedChanged(object sender, EventArgs e)
        {
            ValidateTimeRadioButtons();
        }

        private void ValidateTimeRadioButtons()
        {
            panelTimeOptions.Visible = radioButtonCustomTime.Checked;

            tableLayoutMainPanel.RowStyles[3] = (radioButtonCustomTime.Checked) ? new RowStyle(SizeType.Absolute, 28F) : new RowStyle(SizeType.Absolute, 0F);
            Size = (radioButtonCustomTime.Checked) ? new Size(Size.Width, Size.Height + 28) : new Size(Size.Width, Size.Height - 28);
        }

        // Event when the tick happens
        private void timer_Tick(object sender, EventArgs e)
        {
            if (tick)
            {
                string[] currentTimer = labelTimer.Text.Split(':');
                int seg = int.Parse(currentTimer[1]);

                if (seg < 59)
                {
                    labelTimer.Text = currentTimer[0] + ":" + ((seg < 9) ? "0" : "") + ++seg;
                }
                else
                {
                    int min = int.Parse(currentTimer[0]);
                    labelTimer.Text = ((min < 9) ? "0" : "") + ++min + ":00";
                    currentMinutes++;
                }
            }
            tick = !tick;
        }
    }
}
