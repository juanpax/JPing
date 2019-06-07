using System;
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
        public Form()
        {
            InitializeComponent();
            ValidateRadioButtons();

            EnableDisableElements(true);
        }

        // Method to start the pinging process 
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                EnableDisableElements(false);
                RemovePingMeFile();
                WriteLogRecord("Started");

                string IP = textBoxIP.Text.Trim();

                if (radioButtonICMP.Checked)
                {
                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        while (!bool.Parse(buttonStop.Tag.ToString()))
                        {
                            SendICMPTraffic(IP);
                        }
                        Thread.CurrentThread.IsBackground = false;
                        Thread.CurrentThread.Abort();
                    }).Start();
                }
                else if (radioButtonTCP.Checked)
                {
                    int port = int.Parse(textBoxPort.Text.Trim());

                    new Thread(() =>
                    {
                        while (!bool.Parse(buttonStop.Tag.ToString()))
                        {
                            SendTCPTraffic(IP, port);
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
            buttonStop.Tag = true;
            EnableDisableElements(true);
            WriteLogRecord("Stoped");
        }

        // Method to enable or disable the view components depending if the program is running or not
        private void EnableDisableElements(bool state)
        {
            textBoxIP.Enabled = state;
            radioButtonICMP.Enabled = state;
            radioButtonTCP.Enabled = state;
            textBoxPort.Enabled = state;
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
                (radioButtonICMP.Checked || (radioButtonTCP.Checked && !string.IsNullOrEmpty(textBoxPort.Text.Trim())))
                );
        }

        // Method to delete the PingMe.txt 
        private void RemovePingMeFile()
        {
            if (File.Exists(buttonSelectFileLocation.Text.Trim()))
            {
                File.Delete(buttonSelectFileLocation.Text.Trim());
            }
        }

        // Method to write a record in the PingMe.txt log
        private void WriteLogRecord(string message)
        {
            try
            {
                string text = DateTime.UtcNow.ToString() + " | " + message + "\n";
                File.AppendAllText(buttonSelectFileLocation.Text.Trim(), text);
            }
            catch (Exception ex)
            {
                buttonStop.Tag = false;
                EnableDisableElements(true);
                labelError.Text = "There was an error when writing into the PingMe.txt";
            }
        }

        // Method to send ICMP traffic 
        public void SendICMPTraffic(string IP)
        {
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(IP);

                if (reply.Status != IPStatus.Success)
                {
                    WriteLogRecord(string.Format("Ping {0} returned: ", IP, reply.Status.ToString()));
                }
            }
            catch (Exception ex)
            {
                WriteLogRecord(string.Format("Ping {0}. Error: {1}", IP, ex.Message));
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
                sock.Connect(endPoint);
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
                    string path = fbd.SelectedPath + "\\PingMeLog.txt";

                    buttonSelectFileLocation.Text = "      " + path;
                    toolTip.SetToolTip(buttonSelectFileLocation, path);
                }
            }
        }

        // Method to display or not the Port textBox based on the selected protocol 
        private void ValidateRadioButtons()
        {
            textBoxPort.Visible = radioButtonTCP.Checked;
            labelPort.Visible = radioButtonTCP.Checked;
            labelPort2.Visible = radioButtonTCP.Checked;
        }

        // This method is shared by the two radioButtons
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            ValidateRadioButtons();
        }
    }
}
