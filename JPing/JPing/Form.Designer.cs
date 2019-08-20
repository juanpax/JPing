namespace JPing
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tableLayoutMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelProtocols = new System.Windows.Forms.Panel();
            this.radioButtonTCP = new System.Windows.Forms.RadioButton();
            this.radioButtonICMP = new System.Windows.Forms.RadioButton();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelProtocolOptions = new System.Windows.Forms.Panel();
            this.panelPort = new System.Windows.Forms.Panel();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort2 = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.panelICMPTimeout = new System.Windows.Forms.Panel();
            this.textBoxTimeout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelBytes = new System.Windows.Forms.Panel();
            this.textBoxBytes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelICMPOptions = new System.Windows.Forms.Panel();
            this.radioButtonICMPCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonICMPDefault = new System.Windows.Forms.RadioButton();
            this.labelError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSelectFileLocation = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelStopped = new System.Windows.Forms.Label();
            this.labelStarted = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panelTime = new System.Windows.Forms.Panel();
            this.radioButtonCustomTime = new System.Windows.Forms.RadioButton();
            this.radioButtonTimeDoNotStop = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelTimeOptions = new System.Windows.Forms.Panel();
            this.textBoxCustomTime = new System.Windows.Forms.TextBox();
            this.radioButtonMinutes = new System.Windows.Forms.RadioButton();
            this.radioButtonNumberOfPings = new System.Windows.Forms.RadioButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMinimun = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMaximun = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTimeAverage = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutMainPanel.SuspendLayout();
            this.panelProtocols.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelProtocolOptions.SuspendLayout();
            this.panelPort.SuspendLayout();
            this.panelICMPTimeout.SuspendLayout();
            this.panelBytes.SuspendLayout();
            this.panelICMPOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelTimeOptions.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMainPanel
            // 
            this.tableLayoutMainPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutMainPanel.ColumnCount = 4;
            this.tableLayoutMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutMainPanel.Controls.Add(this.panelProtocols, 2, 4);
            this.tableLayoutMainPanel.Controls.Add(this.textBoxIP, 2, 1);
            this.tableLayoutMainPanel.Controls.Add(this.panel3, 2, 7);
            this.tableLayoutMainPanel.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutMainPanel.Controls.Add(this.panel5, 1, 4);
            this.tableLayoutMainPanel.Controls.Add(this.panelProtocolOptions, 2, 5);
            this.tableLayoutMainPanel.Controls.Add(this.labelError, 2, 8);
            this.tableLayoutMainPanel.Controls.Add(this.panel1, 2, 6);
            this.tableLayoutMainPanel.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutMainPanel.Controls.Add(this.panel7, 1, 2);
            this.tableLayoutMainPanel.Controls.Add(this.panelTime, 2, 2);
            this.tableLayoutMainPanel.Controls.Add(this.panel9, 2, 3);
            this.tableLayoutMainPanel.Controls.Add(this.panel8, 1, 3);
            this.tableLayoutMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMainPanel.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutMainPanel.Name = "tableLayoutMainPanel";
            this.tableLayoutMainPanel.RowCount = 9;
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutMainPanel.Size = new System.Drawing.Size(575, 356);
            this.tableLayoutMainPanel.TabIndex = 0;
            // 
            // panelProtocols
            // 
            this.panelProtocols.Controls.Add(this.radioButtonTCP);
            this.panelProtocols.Controls.Add(this.radioButtonICMP);
            this.panelProtocols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProtocols.Location = new System.Drawing.Point(142, 116);
            this.panelProtocols.Margin = new System.Windows.Forms.Padding(0);
            this.panelProtocols.Name = "panelProtocols";
            this.panelProtocols.Size = new System.Drawing.Size(403, 32);
            this.panelProtocols.TabIndex = 3;
            // 
            // radioButtonTCP
            // 
            this.radioButtonTCP.AutoSize = true;
            this.radioButtonTCP.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonTCP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTCP.Location = new System.Drawing.Point(70, 0);
            this.radioButtonTCP.Name = "radioButtonTCP";
            this.radioButtonTCP.Size = new System.Drawing.Size(58, 32);
            this.radioButtonTCP.TabIndex = 3;
            this.radioButtonTCP.Text = "TCP";
            this.radioButtonTCP.UseVisualStyleBackColor = true;
            // 
            // radioButtonICMP
            // 
            this.radioButtonICMP.AutoSize = true;
            this.radioButtonICMP.Checked = true;
            this.radioButtonICMP.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonICMP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonICMP.Location = new System.Drawing.Point(0, 0);
            this.radioButtonICMP.Name = "radioButtonICMP";
            this.radioButtonICMP.Size = new System.Drawing.Size(70, 32);
            this.radioButtonICMP.TabIndex = 2;
            this.radioButtonICMP.TabStop = true;
            this.radioButtonICMP.Text = "ICMP";
            this.radioButtonICMP.UseVisualStyleBackColor = true;
            this.radioButtonICMP.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIP.Location = new System.Drawing.Point(145, 27);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(397, 27);
            this.textBoxIP.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonStop);
            this.panel3.Controls.Add(this.buttonStart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(145, 291);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 41);
            this.panel3.TabIndex = 7;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Gray;
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.White;
            this.buttonStop.Location = new System.Drawing.Point(250, 0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 41);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Tag = "";
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(325, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 41);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(30, 24);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(112, 32);
            this.panel4.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP or host:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "*";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(30, 116);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(112, 32);
            this.panel5.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Protocol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "*";
            // 
            // panelProtocolOptions
            // 
            this.panelProtocolOptions.Controls.Add(this.panelPort);
            this.panelProtocolOptions.Controls.Add(this.panelICMPTimeout);
            this.panelProtocolOptions.Controls.Add(this.panelBytes);
            this.panelProtocolOptions.Controls.Add(this.panelICMPOptions);
            this.panelProtocolOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProtocolOptions.Location = new System.Drawing.Point(142, 148);
            this.panelProtocolOptions.Margin = new System.Windows.Forms.Padding(0);
            this.panelProtocolOptions.Name = "panelProtocolOptions";
            this.panelProtocolOptions.Size = new System.Drawing.Size(403, 111);
            this.panelProtocolOptions.TabIndex = 14;
            // 
            // panelPort
            // 
            this.panelPort.Controls.Add(this.textBoxPort);
            this.panelPort.Controls.Add(this.labelPort2);
            this.panelPort.Controls.Add(this.labelPort);
            this.panelPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPort.Location = new System.Drawing.Point(0, 84);
            this.panelPort.Margin = new System.Windows.Forms.Padding(0);
            this.panelPort.Name = "panelPort";
            this.panelPort.Size = new System.Drawing.Size(403, 28);
            this.panelPort.TabIndex = 5;
            this.panelPort.Visible = false;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPort.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(55, 0);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(348, 23);
            this.textBoxPort.TabIndex = 4;
            this.textBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelPort2
            // 
            this.labelPort2.AutoSize = true;
            this.labelPort2.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPort2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort2.ForeColor = System.Drawing.Color.Black;
            this.labelPort2.Location = new System.Drawing.Point(17, 0);
            this.labelPort2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort2.Name = "labelPort2";
            this.labelPort2.Size = new System.Drawing.Size(38, 17);
            this.labelPort2.TabIndex = 3;
            this.labelPort2.Text = "Port:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPort.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.ForeColor = System.Drawing.Color.Brown;
            this.labelPort.Location = new System.Drawing.Point(0, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(17, 20);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "*";
            // 
            // panelICMPTimeout
            // 
            this.panelICMPTimeout.Controls.Add(this.textBoxTimeout);
            this.panelICMPTimeout.Controls.Add(this.label6);
            this.panelICMPTimeout.Controls.Add(this.label8);
            this.panelICMPTimeout.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelICMPTimeout.Location = new System.Drawing.Point(0, 56);
            this.panelICMPTimeout.Margin = new System.Windows.Forms.Padding(0);
            this.panelICMPTimeout.Name = "panelICMPTimeout";
            this.panelICMPTimeout.Size = new System.Drawing.Size(403, 28);
            this.panelICMPTimeout.TabIndex = 6;
            this.panelICMPTimeout.Visible = false;
            // 
            // textBoxTimeout
            // 
            this.textBoxTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTimeout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeout.Location = new System.Drawing.Point(170, 0);
            this.textBoxTimeout.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTimeout.Name = "textBoxTimeout";
            this.textBoxTimeout.Size = new System.Drawing.Size(233, 23);
            this.textBoxTimeout.TabIndex = 10;
            this.textBoxTimeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Timeout (milliseconds):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "*";
            // 
            // panelBytes
            // 
            this.panelBytes.Controls.Add(this.textBoxBytes);
            this.panelBytes.Controls.Add(this.label10);
            this.panelBytes.Controls.Add(this.label11);
            this.panelBytes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBytes.Location = new System.Drawing.Point(0, 28);
            this.panelBytes.Margin = new System.Windows.Forms.Padding(0);
            this.panelBytes.Name = "panelBytes";
            this.panelBytes.Size = new System.Drawing.Size(403, 28);
            this.panelBytes.TabIndex = 15;
            this.panelBytes.Visible = false;
            // 
            // textBoxBytes
            // 
            this.textBoxBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBytes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBytes.Location = new System.Drawing.Point(60, 0);
            this.textBoxBytes.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBytes.Name = "textBoxBytes";
            this.textBoxBytes.Size = new System.Drawing.Size(343, 23);
            this.textBoxBytes.TabIndex = 9;
            this.textBoxBytes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Bytes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "*";
            // 
            // panelICMPOptions
            // 
            this.panelICMPOptions.Controls.Add(this.radioButtonICMPCustom);
            this.panelICMPOptions.Controls.Add(this.radioButtonICMPDefault);
            this.panelICMPOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelICMPOptions.Location = new System.Drawing.Point(0, 0);
            this.panelICMPOptions.Margin = new System.Windows.Forms.Padding(0);
            this.panelICMPOptions.Name = "panelICMPOptions";
            this.panelICMPOptions.Size = new System.Drawing.Size(403, 28);
            this.panelICMPOptions.TabIndex = 16;
            // 
            // radioButtonICMPCustom
            // 
            this.radioButtonICMPCustom.AutoSize = true;
            this.radioButtonICMPCustom.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonICMPCustom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonICMPCustom.Location = new System.Drawing.Point(73, 0);
            this.radioButtonICMPCustom.Name = "radioButtonICMPCustom";
            this.radioButtonICMPCustom.Size = new System.Drawing.Size(77, 28);
            this.radioButtonICMPCustom.TabIndex = 8;
            this.radioButtonICMPCustom.Text = "Custom";
            this.radioButtonICMPCustom.UseVisualStyleBackColor = true;
            // 
            // radioButtonICMPDefault
            // 
            this.radioButtonICMPDefault.AutoSize = true;
            this.radioButtonICMPDefault.Checked = true;
            this.radioButtonICMPDefault.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonICMPDefault.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonICMPDefault.Location = new System.Drawing.Point(0, 0);
            this.radioButtonICMPDefault.Name = "radioButtonICMPDefault";
            this.radioButtonICMPDefault.Size = new System.Drawing.Size(73, 28);
            this.radioButtonICMPDefault.TabIndex = 7;
            this.radioButtonICMPDefault.TabStop = true;
            this.radioButtonICMPDefault.Text = "Default";
            this.radioButtonICMPDefault.UseVisualStyleBackColor = true;
            this.radioButtonICMPDefault.CheckedChanged += new System.EventHandler(this.radioButtonICMPOptions_CheckedChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.White;
            this.labelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(144, 332);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(399, 24);
            this.labelError.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSelectFileLocation);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(142, 259);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 32);
            this.panel1.TabIndex = 15;
            // 
            // buttonSelectFileLocation
            // 
            this.buttonSelectFileLocation.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSelectFileLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSelectFileLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectFileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectFileLocation.ForeColor = System.Drawing.Color.Black;
            this.buttonSelectFileLocation.Image = global::JPing.Properties.Resources.file_icon;
            this.buttonSelectFileLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectFileLocation.Location = new System.Drawing.Point(17, 0);
            this.buttonSelectFileLocation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectFileLocation.Name = "buttonSelectFileLocation";
            this.buttonSelectFileLocation.Size = new System.Drawing.Size(386, 32);
            this.buttonSelectFileLocation.TabIndex = 9;
            this.buttonSelectFileLocation.Text = "      Select log location...";
            this.buttonSelectFileLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectFileLocation.UseVisualStyleBackColor = true;
            this.buttonSelectFileLocation.Click += new System.EventHandler(this.buttonSelectFileLocation_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Brown;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "*";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelStopped);
            this.panel6.Controls.Add(this.labelStarted);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(142, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(403, 24);
            this.panel6.TabIndex = 16;
            // 
            // labelStopped
            // 
            this.labelStopped.AutoSize = true;
            this.labelStopped.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelStopped.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopped.ForeColor = System.Drawing.Color.Brown;
            this.labelStopped.Location = new System.Drawing.Point(277, 0);
            this.labelStopped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStopped.Name = "labelStopped";
            this.labelStopped.Size = new System.Drawing.Size(68, 17);
            this.labelStopped.TabIndex = 6;
            this.labelStopped.Text = "Stopped!";
            this.labelStopped.Visible = false;
            // 
            // labelStarted
            // 
            this.labelStarted.AutoSize = true;
            this.labelStarted.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelStarted.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarted.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelStarted.Location = new System.Drawing.Point(345, 0);
            this.labelStarted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStarted.Name = "labelStarted";
            this.labelStarted.Size = new System.Drawing.Size(58, 17);
            this.labelStarted.TabIndex = 5;
            this.labelStarted.Text = "Started!";
            this.labelStarted.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(30, 56);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(112, 32);
            this.panel7.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Time:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Left;
            this.label15.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Brown;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "*";
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.radioButtonCustomTime);
            this.panelTime.Controls.Add(this.radioButtonTimeDoNotStop);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTime.Location = new System.Drawing.Point(142, 56);
            this.panelTime.Margin = new System.Windows.Forms.Padding(0);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(403, 32);
            this.panelTime.TabIndex = 18;
            // 
            // radioButtonCustomTime
            // 
            this.radioButtonCustomTime.AutoSize = true;
            this.radioButtonCustomTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonCustomTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCustomTime.Location = new System.Drawing.Point(119, 0);
            this.radioButtonCustomTime.Name = "radioButtonCustomTime";
            this.radioButtonCustomTime.Size = new System.Drawing.Size(89, 32);
            this.radioButtonCustomTime.TabIndex = 3;
            this.radioButtonCustomTime.Text = "Custom";
            this.radioButtonCustomTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonTimeDoNotStop
            // 
            this.radioButtonTimeDoNotStop.AutoSize = true;
            this.radioButtonTimeDoNotStop.Checked = true;
            this.radioButtonTimeDoNotStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonTimeDoNotStop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTimeDoNotStop.Location = new System.Drawing.Point(0, 0);
            this.radioButtonTimeDoNotStop.Name = "radioButtonTimeDoNotStop";
            this.radioButtonTimeDoNotStop.Size = new System.Drawing.Size(119, 32);
            this.radioButtonTimeDoNotStop.TabIndex = 2;
            this.radioButtonTimeDoNotStop.TabStop = true;
            this.radioButtonTimeDoNotStop.Text = "Do not stop";
            this.radioButtonTimeDoNotStop.UseVisualStyleBackColor = true;
            this.radioButtonTimeDoNotStop.CheckedChanged += new System.EventHandler(this.radioButtonTimeDoNotStop_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panelTimeOptions);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(142, 88);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(403, 28);
            this.panel9.TabIndex = 19;
            // 
            // panelTimeOptions
            // 
            this.panelTimeOptions.Controls.Add(this.textBoxCustomTime);
            this.panelTimeOptions.Controls.Add(this.radioButtonMinutes);
            this.panelTimeOptions.Controls.Add(this.radioButtonNumberOfPings);
            this.panelTimeOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimeOptions.Location = new System.Drawing.Point(0, 0);
            this.panelTimeOptions.Margin = new System.Windows.Forms.Padding(0);
            this.panelTimeOptions.Name = "panelTimeOptions";
            this.panelTimeOptions.Size = new System.Drawing.Size(403, 32);
            this.panelTimeOptions.TabIndex = 17;
            this.panelTimeOptions.Visible = false;
            // 
            // textBoxCustomTime
            // 
            this.textBoxCustomTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCustomTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomTime.Location = new System.Drawing.Point(211, 0);
            this.textBoxCustomTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCustomTime.Name = "textBoxCustomTime";
            this.textBoxCustomTime.Size = new System.Drawing.Size(192, 23);
            this.textBoxCustomTime.TabIndex = 9;
            this.textBoxCustomTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // radioButtonMinutes
            // 
            this.radioButtonMinutes.AutoSize = true;
            this.radioButtonMinutes.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonMinutes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMinutes.Location = new System.Drawing.Point(133, 0);
            this.radioButtonMinutes.Name = "radioButtonMinutes";
            this.radioButtonMinutes.Size = new System.Drawing.Size(78, 32);
            this.radioButtonMinutes.TabIndex = 8;
            this.radioButtonMinutes.Text = "Minutes:";
            this.radioButtonMinutes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumberOfPings
            // 
            this.radioButtonNumberOfPings.AutoSize = true;
            this.radioButtonNumberOfPings.Checked = true;
            this.radioButtonNumberOfPings.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonNumberOfPings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNumberOfPings.Location = new System.Drawing.Point(0, 0);
            this.radioButtonNumberOfPings.Name = "radioButtonNumberOfPings";
            this.radioButtonNumberOfPings.Size = new System.Drawing.Size(133, 32);
            this.radioButtonNumberOfPings.TabIndex = 7;
            this.radioButtonNumberOfPings.TabStop = true;
            this.radioButtonNumberOfPings.Text = "Number of pings";
            this.radioButtonNumberOfPings.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.labelTimer);
            this.panel8.Controls.Add(this.labelCounter);
            this.panel8.Location = new System.Drawing.Point(32, 90);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(107, 23);
            this.panel8.TabIndex = 21;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTimer.Location = new System.Drawing.Point(60, 0);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(34, 13);
            this.labelTimer.TabIndex = 20;
            this.labelTimer.Text = "00:00";
            this.labelTimer.Visible = false;
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelCounter.Location = new System.Drawing.Point(94, 0);
            this.labelCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(13, 13);
            this.labelCounter.TabIndex = 22;
            this.labelCounter.Text = "0";
            this.labelCounter.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutMainPanel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(591, 404);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelMinimun, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelMaximun, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelTimeAverage, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 364);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(575, 32);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Min:";
            // 
            // labelMinimun
            // 
            this.labelMinimun.AutoSize = true;
            this.labelMinimun.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimun.Location = new System.Drawing.Point(217, 0);
            this.labelMinimun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinimun.Name = "labelMinimun";
            this.labelMinimun.Size = new System.Drawing.Size(15, 17);
            this.labelMinimun.TabIndex = 1;
            this.labelMinimun.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(275, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Max:";
            // 
            // labelMaximun
            // 
            this.labelMaximun.AutoSize = true;
            this.labelMaximun.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaximun.Location = new System.Drawing.Point(325, 0);
            this.labelMaximun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaximun.Name = "labelMaximun";
            this.labelMaximun.Size = new System.Drawing.Size(15, 17);
            this.labelMaximun.TabIndex = 3;
            this.labelMaximun.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Average:";
            // 
            // labelTimeAverage
            // 
            this.labelTimeAverage.AutoSize = true;
            this.labelTimeAverage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeAverage.Location = new System.Drawing.Point(458, 0);
            this.labelTimeAverage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeAverage.Name = "labelTimeAverage";
            this.labelTimeAverage.Size = new System.Drawing.Size(15, 17);
            this.labelTimeAverage.TabIndex = 5;
            this.labelTimeAverage.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Successful traffic";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(163, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 26);
            this.panel2.TabIndex = 7;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 404);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JPing";
            this.tableLayoutMainPanel.ResumeLayout(false);
            this.tableLayoutMainPanel.PerformLayout();
            this.panelProtocols.ResumeLayout(false);
            this.panelProtocols.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelProtocolOptions.ResumeLayout(false);
            this.panelPort.ResumeLayout(false);
            this.panelPort.PerformLayout();
            this.panelICMPTimeout.ResumeLayout(false);
            this.panelICMPTimeout.PerformLayout();
            this.panelBytes.ResumeLayout(false);
            this.panelBytes.PerformLayout();
            this.panelICMPOptions.ResumeLayout(false);
            this.panelICMPOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panelTimeOptions.ResumeLayout(false);
            this.panelTimeOptions.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelProtocols;
        private System.Windows.Forms.RadioButton radioButtonTCP;
        private System.Windows.Forms.RadioButton radioButtonICMP;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Panel panelPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSelectFileLocation;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPort2;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMinimun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMaximun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTimeAverage;
        private System.Windows.Forms.Panel panelProtocolOptions;
        private System.Windows.Forms.Panel panelICMPTimeout;
        private System.Windows.Forms.TextBox textBoxBytes;
        private System.Windows.Forms.RadioButton radioButtonICMPCustom;
        private System.Windows.Forms.RadioButton radioButtonICMPDefault;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTimeout;
        private System.Windows.Forms.Panel panelBytes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelICMPOptions;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelStopped;
        private System.Windows.Forms.Label labelStarted;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.RadioButton radioButtonCustomTime;
        private System.Windows.Forms.RadioButton radioButtonTimeDoNotStop;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelTimeOptions;
        private System.Windows.Forms.TextBox textBoxCustomTime;
        private System.Windows.Forms.RadioButton radioButtonMinutes;
        private System.Windows.Forms.RadioButton radioButtonNumberOfPings;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelCounter;
    }
}

