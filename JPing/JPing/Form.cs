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
 * To develop: Include functionality to send UDP traffic 
 */

namespace JPing
{
    public partial class Form : System.Windows.Forms.Form
    {
        private bool StartThread = false;
        private List<long> TimeAverageList = new List<long>();

        public Form()
        {
            InitializeComponent();
            Size = new Size(Size.Width, Size.Height - 80);

            ValidateRadioButtons();
            EnableDisableElements(true);
        }

        // Method to start the pinging process 
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ResetLabels();
                EnableDisableElements(false);
                RemovePingMeFile();
                WriteLogRecord("Started");

                StartThread = true;
                string timeMethod =
                        (radioButtonTimeDoNotStop.Checked) ? "Do not stop" :
                        (radioButtonNumberOfPings.Checked) ? "Number of pings" :
                        (radioButtonMinutes.Checked) ? "Minutes" : "";
                string IP = textBoxIP.Text.Trim();

                if (radioButtonICMP.Checked)
                {
                    new Thread(() =>
                    {
                        switch (timeMethod)
                        {
                            case "Do not stop":
                                {
                                    while (StartThread)
                                    {
                                        SendICMPTraffic(IP);
                                        Thread.Sleep(1000);
                                    }
                                    return;
                                }
                            case "Number of pings":
                                {
                                    long numberOfPings = long.Parse(textBoxCustomTime.Text);

                                    while (StartThread && numberOfPings > 0)
                                    {
                                        SendICMPTraffic(IP);
                                        Thread.Sleep(1000);

                                        numberOfPings--;
                                    }
                                    return;
                                }
                            case "Minutes":
                                {
                                    //********************* Test this part **********
                                    //************************************************
                                    long minutes = long.Parse(textBoxCustomTime.Text);
                                    timer.Enabled = true;

                                    while (StartThread && long.Parse(label16.Text.Split(':')[0]) < minutes)
                                    {
                                        SendICMPTraffic(IP);
                                        Thread.Sleep(1000);
                                    }
                                    timer.Enabled = false;
                                    return;
                                }
                        }
                    }).Start();
                }
                else if (radioButtonTCP.Checked)
                {
                    int port = int.Parse(textBoxPort.Text.Trim());

                    new Thread(() =>
                    {
                        switch (timeMethod)
                        {
                            case "Do not stop":
                                {
                                    while (StartThread)
                                    {
                                        SendTCPTraffic(IP, port);
                                        Thread.Sleep(1000);
                                    }
                                    return;
                                }
                            case "Number of pings":
                                {
                                    long numberOfPings = long.Parse(textBoxCustomTime.Text);

                                    while (StartThread && numberOfPings > 0)
                                    {
                                        SendTCPTraffic(IP, port);
                                        Thread.Sleep(1000);

                                        numberOfPings--;
                                    }
                                    return;
                                }
                            case "Minutes":
                                {
                                    long minutes = long.Parse(textBoxCustomTime.Text);

                                    while (StartThread && long.Parse(label16.Text.Split(':')[0]) < minutes)
                                    {
                                        SendTCPTraffic(IP, port);
                                        Thread.Sleep(1000);
                                    }
                                    return;
                                }
                        }
                    }).Start();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the required information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetLabels()
        {
            label16.Text = "00:00";
            labelStopped.Visible = false;
            labelStarted.Visible = true;
            labelMinimun.Text = "0";
            labelMaximun.Text = "0";
            labelTimeAverage.Text = "0";
        }

        // Method to stop the pinging process
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;

            labelStarted.Visible = false;
            labelStopped.Visible = true;

            StartThread = false;
            EnableDisableElements(true);
            ProcessTimeValues();
            WriteLogRecord("Stoped");
        }

        private void ProcessTimeValues()
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

                labelMinimun.Text = MinimunTime.ToString() + "ms";
                labelMaximun.Text = MaximunTime.ToString() + "ms";
                labelTimeAverage.Text = (total / TimeAverageList.Count).ToString() + "ms";

                TimeAverageList.Clear();
            }
        }

        // Method to enable or disable the view components depending if the program is running or not
        private void EnableDisableElements(bool state)
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

        // Method to validate the form before starting the pinging process
        public bool ValidateForm()
        {
            return (
                !string.IsNullOrEmpty(textBoxIP.Text.Trim()) &&
                (radioButtonCustomTime.Checked && !string.IsNullOrEmpty(textBoxCustomTime.Text.Trim())) &&
                buttonSelectFileLocation.Text.Trim() != "Select log location..." &&
                    (
                        (radioButtonICMP.Checked && (radioButtonICMPDefault.Checked || (radioButtonICMPCustom.Checked && !string.IsNullOrEmpty(textBoxBytes.Text.Trim()) && !string.IsNullOrEmpty(textBoxTimeout.Text.Trim())))) ||
                        (radioButtonTCP.Checked && !string.IsNullOrEmpty(textBoxPort.Text.Trim()))
                    )
                );
        }

        // Method to delete the JPing.txt 
        private void RemovePingMeFile()
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
                EnableDisableElements(true);
                ProcessTimeValues();
                labelError.Text = "There was an error when writing into the JPingLog.txt";
            }
        }

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
        private void SendTCPTraffic(string IP, int port)
        {
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

        private void timer_Tick(object sender, EventArgs e)
        {
            string[] currentTimer = label16.Text.Split(':');
            int seg = int.Parse(currentTimer[1]);

            if (seg < 59)
            {
                label16.Text = currentTimer[0] + ":" + ((seg < 9) ? "0" : "") + ++seg;
            }
            else
            {
                int min = int.Parse(currentTimer[0]);

                label16.Text = ((min < 9) ? "0" : "") + ++min + ":00";
            }
        }
    }
}
