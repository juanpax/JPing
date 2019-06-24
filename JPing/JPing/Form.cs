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

namespace JPing
{
    public partial class Form : System.Windows.Forms.Form
    {
        private bool StartThread = false;
        private List<long> TimeAverageList = new List<long>();

        private int BaseWindowHeight = 0;

        public Form()
        {
            InitializeComponent();
            BaseWindowHeight = Size.Height;

            ValidateRadioButtons();
            EnableDisableElements(true);
        }

        // Method to start the pinging process 
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                labelStopped.Visible = false;
                labelStarted.Visible = true;
                labelMinimun.Text = "0";
                labelMaximun.Text = "0";
                labelTimeAverage.Text = "0";

                EnableDisableElements(false);
                StartThread = true;
                RemovePingMeFile();
                WriteLogRecord("Started");

                string IP = textBoxIP.Text.Trim();

                if (radioButtonICMP.Checked)
                {
                    new Thread(() =>
                    {
                        while (StartThread)
                        {
                            SendICMPTraffic(IP);
                            Thread.Sleep(1000);
                        }
                    }).Start();
                }
                else if (radioButtonTCP.Checked)
                {
                    int port = int.Parse(textBoxPort.Text.Trim());

                    new Thread(() =>
                    {
                        while (StartThread)
                        {
                            SendTCPTraffic(IP, port);
                            Thread.Sleep(1000);
                        }
                    }).Start();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the required information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to stop the pinging process
        private void buttonStop_Click(object sender, EventArgs e)
        {
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
            panelProtocols.Enabled = state;
            panelOptions.Enabled = state;
            buttonSelectFileLocation.Enabled = state;
            buttonStart.Enabled = state;
            buttonStop.Enabled = !state;
        }

        // Method to validate the form before starting the pinging process
        public bool ValidateForm()
        {
            return (
                !string.IsNullOrEmpty(textBoxIP.Text.Trim()) &&
                buttonSelectFileLocation.Text.Trim() != "Select log location..." &&
                    (
                        (radioButtonICMP.Checked && (radioButtonDefault.Checked || (radioButtonCustom.Checked && !string.IsNullOrEmpty(textBoxBytes.Text.Trim()) && !string.IsNullOrEmpty(textBoxTimeout.Text.Trim())))) ||
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

                if (radioButtonCustom.Checked)
                {
                    int bytes = int.Parse(textBoxBytes.Text.Trim());
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
                IPAddress IPAddress = IPAddress.Parse(IP);
                IPEndPoint endPoint = new IPEndPoint(IPAddress, port);
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                sock.Connect(endPoint);
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
            panelICMPOptions.Visible = radioButtonICMP.Checked;
            panelPort.Visible = radioButtonTCP.Checked;

            if (radioButtonTCP.Checked)
            {
                Size = new Size(Size.Width, BaseWindowHeight);
            }

            ValidateICMPRadioButtons();
        }

        // This method is shared by the two radioButtons
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            ValidateRadioButtons();
        }

        // Event to be able only to type numbers 
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void radioButtonICMP_CheckedChanged(object sender, EventArgs e)
        {
            ValidateICMPRadioButtons();
        }

        private void ValidateICMPRadioButtons()
        {
            panelTimeout.Visible = radioButtonCustom.Checked && radioButtonICMP.Checked;
            panelBytes.Visible = radioButtonCustom.Checked && radioButtonICMP.Checked;

            if (radioButtonICMP.Checked)
            {
                Size = (radioButtonDefault.Checked) ? new Size(Size.Width, BaseWindowHeight) : new Size(Size.Width, BaseWindowHeight + 56);
            }
        }
    }
}
