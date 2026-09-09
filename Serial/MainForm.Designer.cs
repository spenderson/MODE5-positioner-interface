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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.azPosTextBox = new System.Windows.Forms.TextBox();
            this.elPosTextBox = new System.Windows.Forms.TextBox();
            this.elVelTextBox = new System.Windows.Forms.TextBox();
            this.azVelTextBox = new System.Windows.Forms.TextBox();
            this.elAccTextBox = new System.Windows.Forms.TextBox();
            this.azAccTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.azPosSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPosSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azVelSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elVelSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elAccelSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azAccelSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxComport
            // 
            this.cboxComport.FormattingEnabled = true;
            this.cboxComport.Location = new System.Drawing.Point(16, 15);
            this.cboxComport.Margin = new System.Windows.Forms.Padding(4);
            this.cboxComport.Name = "cboxComport";
            this.cboxComport.Size = new System.Drawing.Size(160, 24);
            this.cboxComport.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(199, 15);
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
            this.cboxBaudrate.Location = new System.Drawing.Point(16, 48);
            this.cboxBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.cboxBaudrate.Name = "cboxBaudrate";
            this.cboxBaudrate.Size = new System.Drawing.Size(160, 24);
            this.cboxBaudrate.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(424, 15);
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
            this.btnSend.Location = new System.Drawing.Point(405, 402);
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
            this.tboxReceive.Location = new System.Drawing.Point(16, 778);
            this.tboxReceive.Margin = new System.Windows.Forms.Padding(4);
            this.tboxReceive.Multiline = true;
            this.tboxReceive.Name = "tboxReceive";
            this.tboxReceive.Size = new System.Drawing.Size(500, 123);
            this.tboxReceive.TabIndex = 6;
            // 
            // azPosSlider
            // 
            this.azPosSlider.Location = new System.Drawing.Point(82, 136);
            this.azPosSlider.Maximum = 360;
            this.azPosSlider.Name = "azPosSlider";
            this.azPosSlider.Size = new System.Drawing.Size(434, 56);
            this.azPosSlider.TabIndex = 7;
            // 
            // elPosSlider
            // 
            this.elPosSlider.Location = new System.Drawing.Point(82, 181);
            this.elPosSlider.Maximum = 90;
            this.elPosSlider.Name = "elPosSlider";
            this.elPosSlider.Size = new System.Drawing.Size(434, 56);
            this.elPosSlider.TabIndex = 8;
            // 
            // azVelSlider
            // 
            this.azVelSlider.Location = new System.Drawing.Point(42, 326);
            this.azVelSlider.Maximum = 90;
            this.azVelSlider.Name = "azVelSlider";
            this.azVelSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.azVelSlider.Size = new System.Drawing.Size(56, 104);
            this.azVelSlider.TabIndex = 9;
            this.azVelSlider.Value = 1;
            // 
            // elVelSlider
            // 
            this.elVelSlider.Location = new System.Drawing.Point(106, 326);
            this.elVelSlider.Maximum = 90;
            this.elVelSlider.Name = "elVelSlider";
            this.elVelSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.elVelSlider.Size = new System.Drawing.Size(56, 104);
            this.elVelSlider.TabIndex = 10;
            this.elVelSlider.Value = 1;
            // 
            // elAccelSlider
            // 
            this.elAccelSlider.Location = new System.Drawing.Point(287, 326);
            this.elAccelSlider.Maximum = 90;
            this.elAccelSlider.Name = "elAccelSlider";
            this.elAccelSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.elAccelSlider.Size = new System.Drawing.Size(56, 104);
            this.elAccelSlider.TabIndex = 11;
            this.elAccelSlider.Value = 1;
            // 
            // azAccelSlider
            // 
            this.azAccelSlider.Location = new System.Drawing.Point(223, 326);
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
            this.label1.Location = new System.Drawing.Point(13, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Elevation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Azimuth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Position\r\n(degrees)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Velocity\r\n(deg/sec)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Acceleration\r\n(deg/sec/sec)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Azimuth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Elevation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Elevation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Azimuth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Last received packet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 546);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 32);
            this.label11.TabIndex = 23;
            this.label11.Text = "Position\r\n(degrees)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 611);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 32);
            this.label12.TabIndex = 24;
            this.label12.Text = "Velocity\r\n(deg/sec)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 675);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 32);
            this.label13.TabIndex = 25;
            this.label13.Text = "Acceleration\r\n(deg/sec/sec)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(147, 513);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Azimuth";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(230, 513);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 27;
            this.label15.Text = "Elevation";
            // 
            // azPosTextBox
            // 
            this.azPosTextBox.Location = new System.Drawing.Point(150, 556);
            this.azPosTextBox.Name = "azPosTextBox";
            this.azPosTextBox.Size = new System.Drawing.Size(60, 22);
            this.azPosTextBox.TabIndex = 28;
            // 
            // elPosTextBox
            // 
            this.elPosTextBox.Location = new System.Drawing.Point(233, 556);
            this.elPosTextBox.Name = "elPosTextBox";
            this.elPosTextBox.Size = new System.Drawing.Size(60, 22);
            this.elPosTextBox.TabIndex = 29;
            // 
            // elVelTextBox
            // 
            this.elVelTextBox.Location = new System.Drawing.Point(233, 621);
            this.elVelTextBox.Name = "elVelTextBox";
            this.elVelTextBox.Size = new System.Drawing.Size(60, 22);
            this.elVelTextBox.TabIndex = 31;
            // 
            // azVelTextBox
            // 
            this.azVelTextBox.Location = new System.Drawing.Point(150, 621);
            this.azVelTextBox.Name = "azVelTextBox";
            this.azVelTextBox.Size = new System.Drawing.Size(60, 22);
            this.azVelTextBox.TabIndex = 30;
            // 
            // elAccTextBox
            // 
            this.elAccTextBox.Location = new System.Drawing.Point(233, 685);
            this.elAccTextBox.Name = "elAccTextBox";
            this.elAccTextBox.Size = new System.Drawing.Size(60, 22);
            this.elAccTextBox.TabIndex = 33;
            // 
            // azAccTextBox
            // 
            this.azAccTextBox.Location = new System.Drawing.Point(150, 685);
            this.azAccTextBox.Name = "azAccTextBox";
            this.azAccTextBox.Size = new System.Drawing.Size(60, 22);
            this.azAccTextBox.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 737);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Receive log";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 932);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.elAccTextBox);
            this.Controls.Add(this.azAccTextBox);
            this.Controls.Add(this.elVelTextBox);
            this.Controls.Add(this.azVelTextBox);
            this.Controls.Add(this.elPosTextBox);
            this.Controls.Add(this.azPosTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.azAccelSlider);
            this.Controls.Add(this.elAccelSlider);
            this.Controls.Add(this.elVelSlider);
            this.Controls.Add(this.azVelSlider);
            this.Controls.Add(this.elPosSlider);
            this.Controls.Add(this.azPosSlider);
            this.Controls.Add(this.tboxReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cboxBaudrate);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboxComport);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox azPosTextBox;
        private System.Windows.Forms.TextBox elPosTextBox;
        private System.Windows.Forms.TextBox elVelTextBox;
        private System.Windows.Forms.TextBox azVelTextBox;
        private System.Windows.Forms.TextBox elAccTextBox;
        private System.Windows.Forms.TextBox azAccTextBox;
        private System.Windows.Forms.Label label16;
    }
}

