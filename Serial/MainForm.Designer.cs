namespace Serial
{
    partial class MainForm
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
            this.cboxComport = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboxBaudrate = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tboxReceive = new System.Windows.Forms.TextBox();
            this.azPosSlider = new System.Windows.Forms.TrackBar();
            this.elPosSlider = new System.Windows.Forms.TrackBar();
            this.azVelSlider = new System.Windows.Forms.TrackBar();
            this.elVelSlider = new System.Windows.Forms.TrackBar();
            this.elAccelSlider = new System.Windows.Forms.TrackBar();
            this.azAccelSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.azPosTextBox = new System.Windows.Forms.TextBox();
            this.elPosTextBox = new System.Windows.Forms.TextBox();
            this.elVelTextBox = new System.Windows.Forms.TextBox();
            this.azVelTextBox = new System.Windows.Forms.TextBox();
            this.elAccTextBox = new System.Windows.Forms.TextBox();
            this.azAccTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.azPosSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPosSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azVelSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elVelSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elAccelSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azAccelSlider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxComport
            // 
            this.cboxComport.FormattingEnabled = true;
            this.cboxComport.Location = new System.Drawing.Point(72, 32);
            this.cboxComport.Margin = new System.Windows.Forms.Padding(4);
            this.cboxComport.Name = "cboxComport";
            this.cboxComport.Size = new System.Drawing.Size(160, 24);
            this.cboxComport.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(26, 106);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cboxBaudrate
            // 
            this.cboxBaudrate.FormattingEnabled = true;
            this.cboxBaudrate.Location = new System.Drawing.Point(72, 65);
            this.cboxBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.cboxBaudrate.Name = "cboxBaudrate";
            this.cboxBaudrate.Size = new System.Drawing.Size(160, 24);
            this.cboxBaudrate.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(249, 32);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(409, 374);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 28);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tboxReceive
            // 
            this.tboxReceive.Location = new System.Drawing.Point(9, 371);
            this.tboxReceive.Margin = new System.Windows.Forms.Padding(4);
            this.tboxReceive.Multiline = true;
            this.tboxReceive.Name = "tboxReceive";
            this.tboxReceive.Size = new System.Drawing.Size(500, 123);
            this.tboxReceive.TabIndex = 6;
            // 
            // azPosSlider
            // 
            this.azPosSlider.Location = new System.Drawing.Point(104, 36);
            this.azPosSlider.Maximum = 360;
            this.azPosSlider.Name = "azPosSlider";
            this.azPosSlider.Size = new System.Drawing.Size(260, 56);
            this.azPosSlider.TabIndex = 7;
            // 
            // elPosSlider
            // 
            this.elPosSlider.Location = new System.Drawing.Point(104, 94);
            this.elPosSlider.Maximum = 83;
            this.elPosSlider.Minimum = -38;
            this.elPosSlider.Name = "elPosSlider";
            this.elPosSlider.Size = new System.Drawing.Size(260, 56);
            this.elPosSlider.TabIndex = 8;
            // 
            // azVelSlider
            // 
            this.azVelSlider.Location = new System.Drawing.Point(18, 78);
            this.azVelSlider.Maximum = 90;
            this.azVelSlider.Name = "azVelSlider";
            this.azVelSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.azVelSlider.Size = new System.Drawing.Size(56, 104);
            this.azVelSlider.TabIndex = 9;
            this.azVelSlider.Value = 1;
            // 
            // elVelSlider
            // 
            this.elVelSlider.Location = new System.Drawing.Point(86, 78);
            this.elVelSlider.Maximum = 90;
            this.elVelSlider.Name = "elVelSlider";
            this.elVelSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.elVelSlider.Size = new System.Drawing.Size(56, 104);
            this.elVelSlider.TabIndex = 10;
            this.elVelSlider.Value = 1;
            // 
            // elAccelSlider
            // 
            this.elAccelSlider.Location = new System.Drawing.Point(86, 75);
            this.elAccelSlider.Maximum = 90;
            this.elAccelSlider.Name = "elAccelSlider";
            this.elAccelSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.elAccelSlider.Size = new System.Drawing.Size(56, 104);
            this.elAccelSlider.TabIndex = 11;
            this.elAccelSlider.Value = 1;
            // 
            // azAccelSlider
            // 
            this.azAccelSlider.Location = new System.Drawing.Point(18, 75);
            this.azAccelSlider.Maximum = 90;
            this.azAccelSlider.Name = "azAccelSlider";
            this.azAccelSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.azAccelSlider.Size = new System.Drawing.Size(56, 104);
            this.azAccelSlider.TabIndex = 12;
            this.azAccelSlider.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Elevation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Azimuth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Azimuth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Elevation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Elevation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Azimuth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Last received packet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Position:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Velocity:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Acceleration:";
            // 
            // azPosTextBox
            // 
            this.azPosTextBox.Location = new System.Drawing.Point(109, 27);
            this.azPosTextBox.Name = "azPosTextBox";
            this.azPosTextBox.Size = new System.Drawing.Size(60, 22);
            this.azPosTextBox.TabIndex = 28;
            // 
            // elPosTextBox
            // 
            this.elPosTextBox.Location = new System.Drawing.Point(109, 27);
            this.elPosTextBox.Name = "elPosTextBox";
            this.elPosTextBox.Size = new System.Drawing.Size(60, 22);
            this.elPosTextBox.TabIndex = 29;
            // 
            // elVelTextBox
            // 
            this.elVelTextBox.Location = new System.Drawing.Point(109, 53);
            this.elVelTextBox.Name = "elVelTextBox";
            this.elVelTextBox.Size = new System.Drawing.Size(60, 22);
            this.elVelTextBox.TabIndex = 31;
            // 
            // azVelTextBox
            // 
            this.azVelTextBox.Location = new System.Drawing.Point(109, 53);
            this.azVelTextBox.Name = "azVelTextBox";
            this.azVelTextBox.Size = new System.Drawing.Size(60, 22);
            this.azVelTextBox.TabIndex = 30;
            // 
            // elAccTextBox
            // 
            this.elAccTextBox.Location = new System.Drawing.Point(109, 79);
            this.elAccTextBox.Name = "elAccTextBox";
            this.elAccTextBox.Size = new System.Drawing.Size(60, 22);
            this.elAccTextBox.TabIndex = 33;
            // 
            // azAccTextBox
            // 
            this.azAccTextBox.Location = new System.Drawing.Point(109, 79);
            this.azAccTextBox.Name = "azAccTextBox";
            this.azAccTextBox.Size = new System.Drawing.Size(60, 22);
            this.azAccTextBox.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 330);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Receive log";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.azPosTextBox);
            this.groupBox1.Controls.Add(this.azVelTextBox);
            this.groupBox1.Controls.Add(this.azAccTextBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 117);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Azimuth";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(175, 82);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 16);
            this.label21.TabIndex = 41;
            this.label21.Text = "deg/sec/sec";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(175, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 16);
            this.label20.TabIndex = 40;
            this.label20.Text = "deg/sec";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(175, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "degrees";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.elAccTextBox);
            this.groupBox2.Controls.Add(this.elPosTextBox);
            this.groupBox2.Controls.Add(this.elVelTextBox);
            this.groupBox2.Location = new System.Drawing.Point(22, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 117);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elevation";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(175, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 16);
            this.label22.TabIndex = 41;
            this.label22.Text = "deg/sec/sec";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(175, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 16);
            this.label23.TabIndex = 40;
            this.label23.Text = "deg/sec";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(175, 30);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 16);
            this.label24.TabIndex = 39;
            this.label24.Text = "degrees";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(40, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 16);
            this.label25.TabIndex = 23;
            this.label25.Text = "Position:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(40, 56);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 16);
            this.label26.TabIndex = 24;
            this.label26.Text = "Velocity:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(13, 82);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 16);
            this.label27.TabIndex = 25;
            this.label27.Text = "Acceleration:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Location = new System.Drawing.Point(16, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 423);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmission";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.elPosSlider);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.textBox2);
            this.groupBox8.Controls.Add(this.azPosSlider);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.textBox1);
            this.groupBox8.Location = new System.Drawing.Point(22, 35);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(478, 146);
            this.groupBox8.TabIndex = 34;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Position";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(79, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 16);
            this.label19.TabIndex = 33;
            this.label19.Text = "-38";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(370, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "360";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "83";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 22);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(407, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 22);
            this.textBox2.TabIndex = 23;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox7.Controls.Add(this.azAccelSlider);
            this.groupBox7.Controls.Add(this.elAccelSlider);
            this.groupBox7.Controls.Add(this.textBox5);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.textBox6);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(216, 202);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(153, 200);
            this.groupBox7.TabIndex = 29;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Acceleration";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(86, 47);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(48, 22);
            this.textBox5.TabIndex = 27;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(18, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(48, 22);
            this.textBox6.TabIndex = 26;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox6.Controls.Add(this.elVelSlider);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.azVelSlider);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Location = new System.Drawing.Point(22, 202);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(153, 200);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Velocity";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(86, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(48, 22);
            this.textBox4.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 22);
            this.textBox3.TabIndex = 24;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.cboxComport);
            this.groupBox4.Controls.Add(this.btnConnect);
            this.groupBox4.Controls.Add(this.cboxBaudrate);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Location = new System.Drawing.Point(16, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 150);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RS-232";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "Port:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 16);
            this.label17.TabIndex = 43;
            this.label17.Text = "Baud:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tboxReceive);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Location = new System.Drawing.Point(16, 620);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(521, 509);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receiver";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 1152);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Serial V1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.azPosSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPosSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azVelSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elVelSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elAccelSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azAccelSlider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxComport;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cboxBaudrate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tboxReceive;
        private System.Windows.Forms.TrackBar azPosSlider;
        private System.Windows.Forms.TrackBar elPosSlider;
        private System.Windows.Forms.TrackBar azVelSlider;
        private System.Windows.Forms.TrackBar elVelSlider;
        private System.Windows.Forms.TrackBar elAccelSlider;
        private System.Windows.Forms.TrackBar azAccelSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox azPosTextBox;
        private System.Windows.Forms.TextBox elPosTextBox;
        private System.Windows.Forms.TextBox elVelTextBox;
        private System.Windows.Forms.TextBox azVelTextBox;
        private System.Windows.Forms.TextBox elAccTextBox;
        private System.Windows.Forms.TextBox azAccTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

