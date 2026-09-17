namespace MODE5_Tester
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cboxComport = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboxBaudrate = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendTimer = new System.Windows.Forms.Timer(this.components);
            this.sweepTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.elVelSlider = new System.Windows.Forms.TrackBar();
            this.elVelTextBoxTx = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.azVelSlider = new System.Windows.Forms.TrackBar();
            this.azVelTextBoxTx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.azAccSlider = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.azAccTextBoxTx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.elAccSlider = new System.Windows.Forms.TrackBar();
            this.label31 = new System.Windows.Forms.Label();
            this.elAccTextBoxTx = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.elPosSlider = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.elPosTextBoxTx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.azPosSlider = new System.Windows.Forms.TrackBar();
            this.azPosTextBoxTx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.sendMode = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.sendRate = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elVelSlider)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.azVelSlider)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.azAccSlider)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elAccSlider)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elPosSlider)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.azPosSlider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxComport
            // 
            this.cboxComport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxComport.FormattingEnabled = true;
            this.cboxComport.Location = new System.Drawing.Point(72, 32);
            this.cboxComport.Margin = new System.Windows.Forms.Padding(4);
            this.cboxComport.Name = "cboxComport";
            this.cboxComport.Size = new System.Drawing.Size(103, 24);
            this.cboxComport.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(27, 106);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 28);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cboxBaudrate
            // 
            this.cboxBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBaudrate.FormattingEnabled = true;
            this.cboxBaudrate.Location = new System.Drawing.Point(72, 65);
            this.cboxBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.cboxBaudrate.Name = "cboxBaudrate";
            this.cboxBaudrate.Size = new System.Drawing.Size(103, 24);
            this.cboxBaudrate.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(203, 29);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.cboxComport);
            this.groupBox4.Controls.Add(this.btnConnect);
            this.groupBox4.Controls.Add(this.cboxBaudrate);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Location = new System.Drawing.Point(12, 31);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(301, 150);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RS-232";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "Port:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 16);
            this.label17.TabIndex = 43;
            this.label17.Text = "Baud:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(651, 28);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sendTimer
            // 
            this.sendTimer.Tick += new System.EventHandler(this.sendTimer_Tick);
            // 
            // sweepTimer
            // 
            this.sweepTimer.Tick += new System.EventHandler(this.sweepTimer_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Controls.Add(this.groupBox12);
            this.groupBox6.Controls.Add(this.groupBox11);
            this.groupBox6.Location = new System.Drawing.Point(118, 268);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(259, 261);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Velocity (degrees/second)";
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox11.Controls.Add(this.label29);
            this.groupBox11.Controls.Add(this.label28);
            this.groupBox11.Controls.Add(this.elVelTextBoxTx);
            this.groupBox11.Controls.Add(this.elVelSlider);
            this.groupBox11.Location = new System.Drawing.Point(132, 25);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Size = new System.Drawing.Size(109, 222);
            this.groupBox11.TabIndex = 37;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Elevation";
            // 
            // elVelSlider
            // 
            this.elVelSlider.Location = new System.Drawing.Point(25, 49);
            this.elVelSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elVelSlider.Maximum = 90;
            this.elVelSlider.Minimum = 1;
            this.elVelSlider.Name = "elVelSlider";
            this.elVelSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.elVelSlider.Size = new System.Drawing.Size(56, 162);
            this.elVelSlider.TabIndex = 10;
            this.elVelSlider.Value = 1;
            this.elVelSlider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // elVelTextBoxTx
            // 
            this.elVelTextBoxTx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elVelTextBoxTx.Location = new System.Drawing.Point(15, 21);
            this.elVelTextBoxTx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elVelTextBoxTx.Name = "elVelTextBoxTx";
            this.elVelTextBoxTx.Size = new System.Drawing.Size(81, 22);
            this.elVelTextBoxTx.TabIndex = 25;
            this.elVelTextBoxTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.elVelTextBoxTx.TextChanged += new System.EventHandler(this.TextBoxTx_TextChanged);
            this.elVelTextBoxTx.Leave += new System.EventHandler(this.ValidateInput);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(61, 53);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(21, 16);
            this.label28.TabIndex = 39;
            this.label28.Text = "90";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(61, 185);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(14, 16);
            this.label29.TabIndex = 40;
            this.label29.Text = "1";
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox12.Controls.Add(this.label2);
            this.groupBox12.Controls.Add(this.label3);
            this.groupBox12.Controls.Add(this.azVelTextBoxTx);
            this.groupBox12.Controls.Add(this.azVelSlider);
            this.groupBox12.Location = new System.Drawing.Point(16, 25);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox12.Size = new System.Drawing.Size(109, 222);
            this.groupBox12.TabIndex = 43;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Azimuth";
            // 
            // azVelSlider
            // 
            this.azVelSlider.Location = new System.Drawing.Point(25, 49);
            this.azVelSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.azVelSlider.Maximum = 90;
            this.azVelSlider.Minimum = 1;
            this.azVelSlider.Name = "azVelSlider";
            this.azVelSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.azVelSlider.Size = new System.Drawing.Size(56, 162);
            this.azVelSlider.TabIndex = 9;
            this.azVelSlider.Value = 1;
            this.azVelSlider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // azVelTextBoxTx
            // 
            this.azVelTextBoxTx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.azVelTextBoxTx.Location = new System.Drawing.Point(15, 21);
            this.azVelTextBoxTx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.azVelTextBoxTx.Name = "azVelTextBoxTx";
            this.azVelTextBoxTx.Size = new System.Drawing.Size(81, 22);
            this.azVelTextBoxTx.TabIndex = 24;
            this.azVelTextBoxTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.azVelTextBoxTx.TextChanged += new System.EventHandler(this.TextBoxTx_TextChanged);
            this.azVelTextBoxTx.Leave += new System.EventHandler(this.ValidateInput);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "90";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.groupBox14);
            this.groupBox7.Controls.Add(this.groupBox13);
            this.groupBox7.Location = new System.Drawing.Point(382, 268);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(259, 261);
            this.groupBox7.TabIndex = 29;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Acceleration (degrees/sec/sec)";
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox13.Controls.Add(this.label7);
            this.groupBox13.Controls.Add(this.azAccTextBoxTx);
            this.groupBox13.Controls.Add(this.label6);
            this.groupBox13.Controls.Add(this.azAccSlider);
            this.groupBox13.Location = new System.Drawing.Point(15, 25);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox13.Size = new System.Drawing.Size(109, 222);
            this.groupBox13.TabIndex = 37;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Azimuth";
            // 
            // azAccSlider
            // 
            this.azAccSlider.Location = new System.Drawing.Point(27, 53);
            this.azAccSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.azAccSlider.Maximum = 90;
            this.azAccSlider.Minimum = 1;
            this.azAccSlider.Name = "azAccSlider";
            this.azAccSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.azAccSlider.Size = new System.Drawing.Size(56, 158);
            this.azAccSlider.TabIndex = 12;
            this.azAccSlider.Value = 1;
            this.azAccSlider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "1";
            // 
            // azAccTextBoxTx
            // 
            this.azAccTextBoxTx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.azAccTextBoxTx.Location = new System.Drawing.Point(15, 21);
            this.azAccTextBoxTx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.azAccTextBoxTx.Name = "azAccTextBoxTx";
            this.azAccTextBoxTx.Size = new System.Drawing.Size(81, 22);
            this.azAccTextBoxTx.TabIndex = 26;
            this.azAccTextBoxTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.azAccTextBoxTx.TextChanged += new System.EventHandler(this.TextBoxTx_TextChanged);
            this.azAccTextBoxTx.Leave += new System.EventHandler(this.ValidateInput);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "90";
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox14.Controls.Add(this.label30);
            this.groupBox14.Controls.Add(this.elAccTextBoxTx);
            this.groupBox14.Controls.Add(this.label31);
            this.groupBox14.Controls.Add(this.elAccSlider);
            this.groupBox14.Location = new System.Drawing.Point(132, 25);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox14.Size = new System.Drawing.Size(109, 222);
            this.groupBox14.TabIndex = 38;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Elevation";
            // 
            // elAccSlider
            // 
            this.elAccSlider.Location = new System.Drawing.Point(27, 53);
            this.elAccSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elAccSlider.Maximum = 90;
            this.elAccSlider.Minimum = 1;
            this.elAccSlider.Name = "elAccSlider";
            this.elAccSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.elAccSlider.Size = new System.Drawing.Size(56, 158);
            this.elAccSlider.TabIndex = 11;
            this.elAccSlider.Value = 1;
            this.elAccSlider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(61, 53);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(21, 16);
            this.label31.TabIndex = 43;
            this.label31.Text = "90";
            // 
            // elAccTextBoxTx
            // 
            this.elAccTextBoxTx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elAccTextBoxTx.Location = new System.Drawing.Point(15, 21);
            this.elAccTextBoxTx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elAccTextBoxTx.Name = "elAccTextBoxTx";
            this.elAccTextBoxTx.Size = new System.Drawing.Size(81, 22);
            this.elAccTextBoxTx.TabIndex = 27;
            this.elAccTextBoxTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.elAccTextBoxTx.TextChanged += new System.EventHandler(this.TextBoxTx_TextChanged);
            this.elAccTextBoxTx.Leave += new System.EventHandler(this.ValidateInput);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(61, 185);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(14, 16);
            this.label30.TabIndex = 44;
            this.label30.Text = "1";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.elPosTextBoxTx);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Controls.Add(this.elPosSlider);
            this.groupBox9.Location = new System.Drawing.Point(12, 185);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Size = new System.Drawing.Size(100, 344);
            this.groupBox9.TabIndex = 35;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Elevation";
            // 
            // elPosSlider
            // 
            this.elPosSlider.Location = new System.Drawing.Point(16, 60);
            this.elPosSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elPosSlider.Maximum = 83;
            this.elPosSlider.Minimum = -38;
            this.elPosSlider.Name = "elPosSlider";
            this.elPosSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.elPosSlider.Size = new System.Drawing.Size(56, 259);
            this.elPosSlider.TabIndex = 8;
            this.elPosSlider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(53, 293);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 16);
            this.label19.TabIndex = 33;
            this.label19.Text = "-38°";
            // 
            // elPosTextBoxTx
            // 
            this.elPosTextBoxTx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elPosTextBoxTx.Location = new System.Drawing.Point(11, 32);
            this.elPosTextBoxTx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elPosTextBoxTx.Name = "elPosTextBoxTx";
            this.elPosTextBoxTx.Size = new System.Drawing.Size(81, 22);
            this.elPosTextBoxTx.TabIndex = 23;
            this.elPosTextBoxTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.elPosTextBoxTx.TextChanged += new System.EventHandler(this.TextBoxTx_TextChanged);
            this.elPosTextBoxTx.Leave += new System.EventHandler(this.ValidateInput);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "83°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "0°";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Controls.Add(this.azPosTextBoxTx);
            this.groupBox10.Controls.Add(this.azPosSlider);
            this.groupBox10.Location = new System.Drawing.Point(117, 185);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Size = new System.Drawing.Size(524, 79);
            this.groupBox10.TabIndex = 36;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Azimuth";
            // 
            // azPosSlider
            // 
            this.azPosSlider.Location = new System.Drawing.Point(105, 17);
            this.azPosSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.azPosSlider.Maximum = 360;
            this.azPosSlider.Name = "azPosSlider";
            this.azPosSlider.Size = new System.Drawing.Size(367, 56);
            this.azPosSlider.TabIndex = 7;
            this.azPosSlider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // azPosTextBoxTx
            // 
            this.azPosTextBoxTx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.azPosTextBoxTx.Location = new System.Drawing.Point(12, 21);
            this.azPosTextBoxTx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.azPosTextBoxTx.Name = "azPosTextBoxTx";
            this.azPosTextBoxTx.Size = new System.Drawing.Size(81, 22);
            this.azPosTextBoxTx.TabIndex = 22;
            this.azPosTextBoxTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.azPosTextBoxTx.TextChanged += new System.EventHandler(this.TextBoxTx_TextChanged);
            this.azPosTextBoxTx.Leave += new System.EventHandler(this.ValidateInput);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "0°";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(473, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "360°";
            // 
            // sendMode
            // 
            this.sendMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sendMode.FormattingEnabled = true;
            this.sendMode.Items.AddRange(new object[] {
            "Use Position Controls",
            "Sweep"});
            this.sendMode.Location = new System.Drawing.Point(78, 35);
            this.sendMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendMode.Name = "sendMode";
            this.sendMode.Size = new System.Drawing.Size(178, 24);
            this.sendMode.TabIndex = 37;
            this.sendMode.SelectedIndexChanged += new System.EventHandler(this.sendSettingChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(173, 106);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 28);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // sendRate
            // 
            this.sendRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sendRate.FormattingEnabled = true;
            this.sendRate.Items.AddRange(new object[] {
            "Single Packet",
            "1 Hz",
            "10 Hz",
            "Continuous"});
            this.sendRate.Location = new System.Drawing.Point(78, 65);
            this.sendRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendRate.Name = "sendRate";
            this.sendRate.Size = new System.Drawing.Size(121, 24);
            this.sendRate.TabIndex = 37;
            this.sendRate.SelectedIndexChanged += new System.EventHandler(this.sendSettingChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.sendRate);
            this.groupBox2.Controls.Add(this.sendMode);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Location = new System.Drawing.Point(319, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 150);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Mode:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Rate:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MODE5 Tester";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elVelSlider)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.azVelSlider)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.azAccSlider)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elAccSlider)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elPosSlider)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.azPosSlider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxComport;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cboxBaudrate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer sendTimer;
        private System.Windows.Forms.Timer sweepTimer;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox azVelTextBoxTx;
        private System.Windows.Forms.TrackBar azVelSlider;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox elVelTextBoxTx;
        private System.Windows.Forms.TrackBar elVelSlider;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox elAccTextBoxTx;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TrackBar elAccSlider;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox azAccTextBoxTx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar azAccSlider;
        private System.Windows.Forms.ComboBox sendRate;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox sendMode;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox azPosTextBoxTx;
        private System.Windows.Forms.TrackBar azPosSlider;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox elPosTextBoxTx;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TrackBar elPosSlider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

