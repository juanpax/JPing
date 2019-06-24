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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panelPort = new System.Windows.Forms.Panel();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort2 = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.panelTimeout = new System.Windows.Forms.Panel();
            this.textBoxTimeout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelBytes = new System.Windows.Forms.Panel();
            this.textBoxBytes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelICMPOptions = new System.Windows.Forms.Panel();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.labelError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSelectFileLocation = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMinimun = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMaximun = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTimeAverage = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelStarted = new System.Windows.Forms.Label();
            this.labelStopped = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelProtocols.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.panelPort.SuspendLayout();
            this.panelTimeout.SuspendLayout();
            this.panelBytes.SuspendLayout();
            this.panelICMPOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panelProtocols, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxIP, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelOptions, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelError, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 215);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelProtocols
            // 
            this.panelProtocols.Controls.Add(this.radioButtonTCP);
            this.panelProtocols.Controls.Add(this.radioButtonICMP);
            this.panelProtocols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProtocols.Location = new System.Drawing.Point(142, 56);
            this.panelProtocols.Margin = new System.Windows.Forms.Padding(0);
            this.panelProtocols.Name = "panelProtocols";
            this.panelProtocols.Size = new System.Drawing.Size(371, 32);
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
            this.textBoxIP.Size = new System.Drawing.Size(365, 27);
            this.textBoxIP.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonStop);
            this.panel3.Controls.Add(this.buttonStart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(145, 150);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 41);
            this.panel3.TabIndex = 7;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Brown;
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.White;
            this.buttonStop.Location = new System.Drawing.Point(218, 0);
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
            this.buttonStart.Location = new System.Drawing.Point(293, 0);
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
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
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
            this.panel5.Location = new System.Drawing.Point(30, 56);
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
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.panelPort);
            this.panelOptions.Controls.Add(this.panelTimeout);
            this.panelOptions.Controls.Add(this.panelBytes);
            this.panelOptions.Controls.Add(this.panelICMPOptions);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOptions.Location = new System.Drawing.Point(142, 88);
            this.panelOptions.Margin = new System.Windows.Forms.Padding(0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(371, 30);
            this.panelOptions.TabIndex = 14;
            // 
            // panelPort
            // 
            this.panelPort.Controls.Add(this.textBoxPort);
            this.panelPort.Controls.Add(this.labelPort2);
            this.panelPort.Controls.Add(this.labelPort);
            this.panelPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPort.Location = new System.Drawing.Point(0, 88);
            this.panelPort.Margin = new System.Windows.Forms.Padding(0);
            this.panelPort.Name = "panelPort";
            this.panelPort.Size = new System.Drawing.Size(371, 28);
            this.panelPort.TabIndex = 5;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPort.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(55, 0);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(316, 23);
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
            // panelTimeout
            // 
            this.panelTimeout.Controls.Add(this.textBoxTimeout);
            this.panelTimeout.Controls.Add(this.label6);
            this.panelTimeout.Controls.Add(this.label8);
            this.panelTimeout.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimeout.Location = new System.Drawing.Point(0, 60);
            this.panelTimeout.Margin = new System.Windows.Forms.Padding(0);
            this.panelTimeout.Name = "panelTimeout";
            this.panelTimeout.Size = new System.Drawing.Size(371, 28);
            this.panelTimeout.TabIndex = 6;
            // 
            // textBoxTimeout
            // 
            this.textBoxTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTimeout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeout.Location = new System.Drawing.Point(170, 0);
            this.textBoxTimeout.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTimeout.Name = "textBoxTimeout";
            this.textBoxTimeout.Size = new System.Drawing.Size(201, 23);
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
            this.panelBytes.Location = new System.Drawing.Point(0, 32);
            this.panelBytes.Margin = new System.Windows.Forms.Padding(0);
            this.panelBytes.Name = "panelBytes";
            this.panelBytes.Size = new System.Drawing.Size(371, 28);
            this.panelBytes.TabIndex = 15;
            // 
            // textBoxBytes
            // 
            this.textBoxBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBytes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBytes.Location = new System.Drawing.Point(60, 0);
            this.textBoxBytes.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBytes.Name = "textBoxBytes";
            this.textBoxBytes.Size = new System.Drawing.Size(311, 23);
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
            this.panelICMPOptions.Controls.Add(this.radioButtonCustom);
            this.panelICMPOptions.Controls.Add(this.radioButtonDefault);
            this.panelICMPOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelICMPOptions.Location = new System.Drawing.Point(0, 0);
            this.panelICMPOptions.Margin = new System.Windows.Forms.Padding(0);
            this.panelICMPOptions.Name = "panelICMPOptions";
            this.panelICMPOptions.Size = new System.Drawing.Size(371, 32);
            this.panelICMPOptions.TabIndex = 16;
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonCustom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCustom.Location = new System.Drawing.Point(73, 0);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(77, 32);
            this.radioButtonCustom.TabIndex = 8;
            this.radioButtonCustom.Text = "Custom";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Checked = true;
            this.radioButtonDefault.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonDefault.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDefault.Location = new System.Drawing.Point(0, 0);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(73, 32);
            this.radioButtonDefault.TabIndex = 7;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Default";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            this.radioButtonDefault.CheckedChanged += new System.EventHandler(this.radioButtonICMP_CheckedChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.White;
            this.labelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(144, 191);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(367, 24);
            this.labelError.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSelectFileLocation);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(142, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 32);
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
            this.buttonSelectFileLocation.Size = new System.Drawing.Size(354, 32);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 1);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(559, 263);
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
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelMinimun, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelMaximun, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelTimeAverage, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 223);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(543, 32);
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
            this.label7.Location = new System.Drawing.Point(274, 0);
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
            this.labelMaximun.Location = new System.Drawing.Point(324, 0);
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
            this.label9.Location = new System.Drawing.Point(381, 0);
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
            this.labelTimeAverage.Location = new System.Drawing.Point(456, 0);
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
            // panel6
            // 
            this.panel6.Controls.Add(this.labelStopped);
            this.panel6.Controls.Add(this.labelStarted);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(142, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(371, 24);
            this.panel6.TabIndex = 16;
            // 
            // labelStarted
            // 
            this.labelStarted.AutoSize = true;
            this.labelStarted.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelStarted.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarted.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelStarted.Location = new System.Drawing.Point(313, 0);
            this.labelStarted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStarted.Name = "labelStarted";
            this.labelStarted.Size = new System.Drawing.Size(58, 17);
            this.labelStarted.TabIndex = 5;
            this.labelStarted.Text = "Started!";
            this.labelStarted.Visible = false;
            // 
            // labelStopped
            // 
            this.labelStopped.AutoSize = true;
            this.labelStopped.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelStopped.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopped.ForeColor = System.Drawing.Color.Brown;
            this.labelStopped.Location = new System.Drawing.Point(245, 0);
            this.labelStopped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStopped.Name = "labelStopped";
            this.labelStopped.Size = new System.Drawing.Size(68, 17);
            this.labelStopped.TabIndex = 6;
            this.labelStopped.Text = "Stopped!";
            this.labelStopped.Visible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 263);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JPing";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelProtocols.ResumeLayout(false);
            this.panelProtocols.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.panelPort.ResumeLayout(false);
            this.panelPort.PerformLayout();
            this.panelTimeout.ResumeLayout(false);
            this.panelTimeout.PerformLayout();
            this.panelBytes.ResumeLayout(false);
            this.panelBytes.PerformLayout();
            this.panelICMPOptions.ResumeLayout(false);
            this.panelICMPOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelTimeout;
        private System.Windows.Forms.TextBox textBoxBytes;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.RadioButton radioButtonDefault;
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
    }
}

