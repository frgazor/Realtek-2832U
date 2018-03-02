namespace RadioApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.signalLockCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageRadio = new System.Windows.Forms.TabPage();
            this.pictureBoxRDS = new System.Windows.Forms.PictureBox();
            this.pictureBoxStereo = new System.Windows.Forms.PictureBox();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.btnStation10 = new System.Windows.Forms.Button();
            this.btnStation9 = new System.Windows.Forms.Button();
            this.btnStation8 = new System.Windows.Forms.Button();
            this.btnStation7 = new System.Windows.Forms.Button();
            this.btnStation6 = new System.Windows.Forms.Button();
            this.btnStation5 = new System.Windows.Forms.Button();
            this.btnStation4 = new System.Windows.Forms.Button();
            this.btnStation3 = new System.Windows.Forms.Button();
            this.btnStation2 = new System.Windows.Forms.Button();
            this.btnStation1 = new System.Windows.Forms.Button();
            this.digitalDisplayFrequency = new Owf.Controls.DigitalDisplayControl();
            this.btnScanForward = new System.Windows.Forms.Button();
            this.btnScanBack = new System.Windows.Forms.Button();
            this.lblStationName = new System.Windows.Forms.Label();
            this.trackBarFrequency = new System.Windows.Forms.TrackBar();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.tabPageAdvanced = new System.Windows.Forms.TabPage();
            this.updateRdsControl = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.errorThreshold = new System.Windows.Forms.NumericUpDown();
            this.errorCorrectionCheckBox = new System.Windows.Forms.CheckBox();
            this.setFrequencyButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.setFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.softMuteCheckBox = new System.Windows.Forms.CheckBox();
            this.blendCheckBox = new System.Windows.Forms.CheckBox();
            this.switchCheckBox = new System.Windows.Forms.CheckBox();
            this.deemphasisCheckBox = new System.Windows.Forms.CheckBox();
            this.highCutCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.searchIntervalComboBox = new System.Windows.Forms.ComboBox();
            this.numberSearches = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.scanForwards = new System.Windows.Forms.Button();
            this.scanBackwards = new System.Windows.Forms.Button();
            this.bandwidthDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scanStopQuality = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageRDS = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdsStereoCheckBox = new System.Windows.Forms.CheckBox();
            this.dynamicCheckBox = new System.Windows.Forms.CheckBox();
            this.artificalHeadCheckBox = new System.Windows.Forms.CheckBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.rdsQualityTextBox = new System.Windows.Forms.TextBox();
            this.compressedCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trafficInformationTextBox = new System.Windows.Forms.TextBox();
            this.musicCheckBox = new System.Windows.Forms.CheckBox();
            this.programmeTextBox = new System.Windows.Forms.TextBox();
            this.firstAlternateFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.secondAlternateFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.checkBoxPlayStop = new System.Windows.Forms.CheckBox();
            this.checkBoxRDS = new System.Windows.Forms.CheckBox();
            this.timerInfoUpdate = new System.Windows.Forms.Timer(this.components);
            this.progressBarSQ = new System.Windows.Forms.ProgressBar();
            this.TrackbarMaster = new System.Windows.Forms.TrackBar();
            this.tabControl.SuspendLayout();
            this.tabPageRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStereo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
            this.panelDisplay.SuspendLayout();
            this.tabPageAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorThreshold)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSearches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanStopQuality)).BeginInit();
            this.tabPageRDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // signalLockCheckBox
            // 
            this.signalLockCheckBox.AutoCheck = false;
            this.signalLockCheckBox.AutoSize = true;
            this.signalLockCheckBox.Location = new System.Drawing.Point(358, 258);
            this.signalLockCheckBox.Name = "signalLockCheckBox";
            this.signalLockCheckBox.Size = new System.Drawing.Size(82, 17);
            this.signalLockCheckBox.TabIndex = 15;
            this.signalLockCheckBox.Text = "Signal Lock";
            this.signalLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Signal Quality";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageRadio);
            this.tabControl.Controls.Add(this.tabPageAdvanced);
            this.tabControl.Controls.Add(this.tabPageRDS);
            this.tabControl.Location = new System.Drawing.Point(0, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(659, 247);
            this.tabControl.TabIndex = 60;
            // 
            // tabPageRadio
            // 
            this.tabPageRadio.Controls.Add(this.checkBoxSave);
            this.tabPageRadio.Controls.Add(this.btnStation10);
            this.tabPageRadio.Controls.Add(this.btnStation9);
            this.tabPageRadio.Controls.Add(this.btnStation8);
            this.tabPageRadio.Controls.Add(this.btnStation7);
            this.tabPageRadio.Controls.Add(this.btnStation6);
            this.tabPageRadio.Controls.Add(this.btnStation5);
            this.tabPageRadio.Controls.Add(this.btnStation4);
            this.tabPageRadio.Controls.Add(this.btnStation3);
            this.tabPageRadio.Controls.Add(this.btnStation2);
            this.tabPageRadio.Controls.Add(this.btnStation1);
            this.tabPageRadio.Controls.Add(this.btnScanBack);
            this.tabPageRadio.Controls.Add(this.trackBarFrequency);
            this.tabPageRadio.Controls.Add(this.panelDisplay);
            this.tabPageRadio.Location = new System.Drawing.Point(4, 22);
            this.tabPageRadio.Name = "tabPageRadio";
            this.tabPageRadio.Size = new System.Drawing.Size(651, 221);
            this.tabPageRadio.TabIndex = 2;
            this.tabPageRadio.Text = "Radio";
            this.tabPageRadio.UseVisualStyleBackColor = true;
            // 
            // pictureBoxRDS
            // 
            this.pictureBoxRDS.BackColor = System.Drawing.Color.Black;
            this.pictureBoxRDS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRDS.Image")));
            this.pictureBoxRDS.Location = new System.Drawing.Point(345, 0);
            this.pictureBoxRDS.Name = "pictureBoxRDS";
            this.pictureBoxRDS.Size = new System.Drawing.Size(41, 43);
            this.pictureBoxRDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRDS.TabIndex = 81;
            this.pictureBoxRDS.TabStop = false;
            // 
            // pictureBoxStereo
            // 
            this.pictureBoxStereo.BackColor = System.Drawing.Color.Black;
            this.pictureBoxStereo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStereo.Image")));
            this.pictureBoxStereo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxStereo.InitialImage")));
            this.pictureBoxStereo.Location = new System.Drawing.Point(395, 0);
            this.pictureBoxStereo.Name = "pictureBoxStereo";
            this.pictureBoxStereo.Size = new System.Drawing.Size(54, 38);
            this.pictureBoxStereo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStereo.TabIndex = 80;
            this.pictureBoxStereo.TabStop = false;
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSave.BackColor = System.Drawing.Color.Black;
            this.checkBoxSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSave.ForeColor = System.Drawing.Color.Silver;
            this.checkBoxSave.Location = new System.Drawing.Point(529, 157);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(109, 48);
            this.checkBoxSave.TabIndex = 79;
            this.checkBoxSave.Text = "Save station";
            this.checkBoxSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSave.UseVisualStyleBackColor = false;
            // 
            // btnStation10
            // 
            this.btnStation10.BackColor = System.Drawing.Color.Black;
            this.btnStation10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStation10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStation10.Location = new System.Drawing.Point(587, 119);
            this.btnStation10.Name = "btnStation10";
            this.btnStation10.Size = new System.Drawing.Size(61, 23);
            this.btnStation10.TabIndex = 78;
            this.btnStation10.Text = "10";
            this.btnStation10.UseVisualStyleBackColor = false;
            this.btnStation10.Click += new System.EventHandler(this.btnStation10_Click);
            // 
            // btnStation9
            // 
            this.btnStation9.BackColor = System.Drawing.Color.Black;
            this.btnStation9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStation9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStation9.Location = new System.Drawing.Point(519, 119);
            this.btnStation9.Name = "btnStation9";
            this.btnStation9.Size = new System.Drawing.Size(61, 23);
            this.btnStation9.TabIndex = 77;
            this.btnStation9.Text = "9";
            this.btnStation9.UseVisualStyleBackColor = false;
            this.btnStation9.Click += new System.EventHandler(this.btnStation9_Click);
            // 
            // btnStation8
            // 
            this.btnStation8.BackColor = System.Drawing.Color.Black;
            this.btnStation8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStation8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStation8.Location = new System.Drawing.Point(587, 90);
            this.btnStation8.Name = "btnStation8";
            this.btnStation8.Size = new System.Drawing.Size(61, 23);
            this.btnStation8.TabIndex = 76;
            this.btnStation8.Text = "8";
            this.btnStation8.UseVisualStyleBackColor = false;
            this.btnStation8.Click += new System.EventHandler(this.btnStation8_Click);
            // 
            // btnStation7
            // 
            this.btnStation7.BackColor = System.Drawing.Color.Black;
            this.btnStation7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStation7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStation7.Location = new System.Drawing.Point(519, 90);
            this.btnStation7.Name = "btnStation7";
            this.btnStation7.Size = new System.Drawing.Size(61, 23);
            this.btnStation7.TabIndex = 75;
            this.btnStation7.Text = "7";
            this.btnStation7.UseVisualStyleBackColor = false;
            this.btnStation7.Click += new System.EventHandler(this.btnStation7_Click);
            // 
            // btnStation6
            // 
            this.btnStation6.BackColor = System.Drawing.Color.Black;
            this.btnStation6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStation6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStation6.Location = new System.Drawing.Point(587, 61);
            this.btnStation6.Name = "btnStation6";
            this.btnStation6.Size = new System.Drawing.Size(61, 23);
            this.btnStation6.TabIndex = 74;
            this.btnStation6.Text = "6";
            this.btnStation6.UseVisualStyleBackColor = false;
            this.btnStation6.Click += new System.EventHandler(this.btnStation6_Click);
            // 
            // btnStation5
            // 
            this.btnStation5.BackColor = System.Drawing.Color.Black;
            this.btnStation5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStation5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStation5.Location = new System.Drawing.Point(519, 61);
            this.btnStation5.Name = "btnStation5";
            this.btnStation5.Size = new System.Drawing.Size(61, 23);
            this.btnStation5.TabIndex = 73;
            this.btnStation5.Text = "5";
            this.btnStation5.UseVisualStyleBackColor = false;
            this.btnStation5.Click += new System.EventHandler(this.btnStation5_Click);
            // 
            // btnStation4
            // 
            this.btnStation4.BackColor = System.Drawing.Color.Black;
            this.btnStation4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStation4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStation4.Location = new System.Drawing.Point(587, 32);
            this.btnStation4.Name = "btnStation4";
            this.btnStation4.Size = new System.Drawing.Size(61, 23);
            this.btnStation4.TabIndex = 72;
            this.btnStation4.Text = "4";
            this.btnStation4.UseVisualStyleBackColor = false;
            this.btnStation4.Click += new System.EventHandler(this.btnStation4_Click);
            // 
            // btnStation3
            // 
            this.btnStation3.BackColor = System.Drawing.Color.Black;
            this.btnStation3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStation3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStation3.Location = new System.Drawing.Point(519, 32);
            this.btnStation3.Name = "btnStation3";
            this.btnStation3.Size = new System.Drawing.Size(61, 23);
            this.btnStation3.TabIndex = 71;
            this.btnStation3.Text = "3";
            this.btnStation3.UseVisualStyleBackColor = false;
            this.btnStation3.Click += new System.EventHandler(this.btnStation3_Click);
            // 
            // btnStation2
            // 
            this.btnStation2.BackColor = System.Drawing.Color.Black;
            this.btnStation2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStation2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStation2.Location = new System.Drawing.Point(587, 3);
            this.btnStation2.Name = "btnStation2";
            this.btnStation2.Size = new System.Drawing.Size(61, 23);
            this.btnStation2.TabIndex = 70;
            this.btnStation2.Text = "2";
            this.btnStation2.UseVisualStyleBackColor = false;
            this.btnStation2.Click += new System.EventHandler(this.btnStation2_Click);
            // 
            // btnStation1
            // 
            this.btnStation1.BackColor = System.Drawing.Color.Black;
            this.btnStation1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStation1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStation1.Location = new System.Drawing.Point(519, 3);
            this.btnStation1.Name = "btnStation1";
            this.btnStation1.Size = new System.Drawing.Size(61, 23);
            this.btnStation1.TabIndex = 69;
            this.btnStation1.Text = "1";
            this.btnStation1.UseVisualStyleBackColor = false;
            this.btnStation1.Click += new System.EventHandler(this.btnStation1_Click);
            // 
            // digitalDisplayFrequency
            // 
            this.digitalDisplayFrequency.BackColor = System.Drawing.Color.Black;
            this.digitalDisplayFrequency.DigitColor = System.Drawing.Color.GreenYellow;
            this.digitalDisplayFrequency.DigitText = "088.888";
            this.digitalDisplayFrequency.Location = new System.Drawing.Point(8, 41);
            this.digitalDisplayFrequency.Name = "digitalDisplayFrequency";
            this.digitalDisplayFrequency.Size = new System.Drawing.Size(446, 126);
            this.digitalDisplayFrequency.TabIndex = 63;
            // 
            // btnScanForward
            // 
            this.btnScanForward.BackColor = System.Drawing.Color.Black;
            this.btnScanForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanForward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnScanForward.Location = new System.Drawing.Point(411, 170);
            this.btnScanForward.Name = "btnScanForward";
            this.btnScanForward.Size = new System.Drawing.Size(43, 48);
            this.btnScanForward.TabIndex = 68;
            this.btnScanForward.Text = ">";
            this.btnScanForward.UseVisualStyleBackColor = false;
            this.btnScanForward.Click += new System.EventHandler(this.scanForwards_Click);
            // 
            // btnScanBack
            // 
            this.btnScanBack.BackColor = System.Drawing.Color.Black;
            this.btnScanBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnScanBack.Location = new System.Drawing.Point(3, 173);
            this.btnScanBack.Name = "btnScanBack";
            this.btnScanBack.Size = new System.Drawing.Size(43, 45);
            this.btnScanBack.TabIndex = 67;
            this.btnScanBack.Text = "<";
            this.btnScanBack.UseVisualStyleBackColor = false;
            this.btnScanBack.Click += new System.EventHandler(this.scanBackwards_Click);
            // 
            // lblStationName
            // 
            this.lblStationName.BackColor = System.Drawing.Color.Black;
            this.lblStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStationName.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblStationName.Location = new System.Drawing.Point(3, 0);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(336, 43);
            this.lblStationName.TabIndex = 2;
            this.lblStationName.Text = "Station name";
            this.lblStationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBarFrequency
            // 
            this.trackBarFrequency.BackColor = System.Drawing.Color.Black;
            this.trackBarFrequency.LargeChange = 100;
            this.trackBarFrequency.Location = new System.Drawing.Point(52, 173);
            this.trackBarFrequency.Maximum = 108000;
            this.trackBarFrequency.Minimum = 87500;
            this.trackBarFrequency.Name = "trackBarFrequency";
            this.trackBarFrequency.Size = new System.Drawing.Size(353, 45);
            this.trackBarFrequency.SmallChange = 50;
            this.trackBarFrequency.TabIndex = 0;
            this.trackBarFrequency.TickFrequency = 1000;
            this.trackBarFrequency.Value = 87500;
            this.trackBarFrequency.Scroll += new System.EventHandler(this.trackBarFrequency_Scroll);
            this.trackBarFrequency.ValueChanged += new System.EventHandler(this.trackBarFrequency_ValueChanged);
            this.trackBarFrequency.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarFrequency_MouseUp);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.Black;
            this.panelDisplay.Controls.Add(this.TrackbarMaster);
            this.panelDisplay.Controls.Add(this.pictureBoxStereo);
            this.panelDisplay.Controls.Add(this.pictureBoxRDS);
            this.panelDisplay.Controls.Add(this.lblStationName);
            this.panelDisplay.Controls.Add(this.digitalDisplayFrequency);
            this.panelDisplay.Controls.Add(this.btnScanForward);
            this.panelDisplay.Location = new System.Drawing.Point(0, 0);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(651, 221);
            this.panelDisplay.TabIndex = 82;
            // 
            // tabPageAdvanced
            // 
            this.tabPageAdvanced.Controls.Add(this.updateRdsControl);
            this.tabPageAdvanced.Controls.Add(this.label18);
            this.tabPageAdvanced.Controls.Add(this.errorThreshold);
            this.tabPageAdvanced.Controls.Add(this.errorCorrectionCheckBox);
            this.tabPageAdvanced.Controls.Add(this.setFrequencyButton);
            this.tabPageAdvanced.Controls.Add(this.label15);
            this.tabPageAdvanced.Controls.Add(this.setFrequencyTextBox);
            this.tabPageAdvanced.Controls.Add(this.groupBox4);
            this.tabPageAdvanced.Controls.Add(this.label9);
            this.tabPageAdvanced.Controls.Add(this.searchIntervalComboBox);
            this.tabPageAdvanced.Controls.Add(this.numberSearches);
            this.tabPageAdvanced.Controls.Add(this.label8);
            this.tabPageAdvanced.Controls.Add(this.scanForwards);
            this.tabPageAdvanced.Controls.Add(this.scanBackwards);
            this.tabPageAdvanced.Controls.Add(this.bandwidthDropdown);
            this.tabPageAdvanced.Controls.Add(this.label3);
            this.tabPageAdvanced.Controls.Add(this.scanStopQuality);
            this.tabPageAdvanced.Controls.Add(this.label2);
            this.tabPageAdvanced.Controls.Add(this.frequencyTextBox);
            this.tabPageAdvanced.Controls.Add(this.label1);
            this.tabPageAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdvanced.Name = "tabPageAdvanced";
            this.tabPageAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdvanced.Size = new System.Drawing.Size(657, 221);
            this.tabPageAdvanced.TabIndex = 0;
            this.tabPageAdvanced.Text = "Advanced";
            this.tabPageAdvanced.UseVisualStyleBackColor = true;
            // 
            // updateRdsControl
            // 
            this.updateRdsControl.Location = new System.Drawing.Point(308, 194);
            this.updateRdsControl.Name = "updateRdsControl";
            this.updateRdsControl.Size = new System.Drawing.Size(79, 23);
            this.updateRdsControl.TabIndex = 79;
            this.updateRdsControl.Text = "Set";
            this.updateRdsControl.UseVisualStyleBackColor = true;
            this.updateRdsControl.Click += new System.EventHandler(this.updateRdsControl_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 172);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 13);
            this.label18.TabIndex = 78;
            this.label18.Text = "RDS Error Threshold";
            // 
            // errorThreshold
            // 
            this.errorThreshold.Location = new System.Drawing.Point(160, 170);
            this.errorThreshold.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.errorThreshold.Name = "errorThreshold";
            this.errorThreshold.Size = new System.Drawing.Size(120, 20);
            this.errorThreshold.TabIndex = 77;
            // 
            // errorCorrectionCheckBox
            // 
            this.errorCorrectionCheckBox.AutoSize = true;
            this.errorCorrectionCheckBox.Location = new System.Drawing.Point(11, 198);
            this.errorCorrectionCheckBox.Name = "errorCorrectionCheckBox";
            this.errorCorrectionCheckBox.Size = new System.Drawing.Size(125, 17);
            this.errorCorrectionCheckBox.TabIndex = 76;
            this.errorCorrectionCheckBox.Text = "RDS Error Correction";
            this.errorCorrectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // setFrequencyButton
            // 
            this.setFrequencyButton.Location = new System.Drawing.Point(308, 142);
            this.setFrequencyButton.Name = "setFrequencyButton";
            this.setFrequencyButton.Size = new System.Drawing.Size(79, 23);
            this.setFrequencyButton.TabIndex = 75;
            this.setFrequencyButton.Text = "Set";
            this.setFrequencyButton.UseVisualStyleBackColor = true;
            this.setFrequencyButton.Click += new System.EventHandler(this.setFrequencyButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 74;
            this.label15.Text = "Request Frequency";
            // 
            // setFrequencyTextBox
            // 
            this.setFrequencyTextBox.Location = new System.Drawing.Point(160, 144);
            this.setFrequencyTextBox.Name = "setFrequencyTextBox";
            this.setFrequencyTextBox.Size = new System.Drawing.Size(141, 20);
            this.setFrequencyTextBox.TabIndex = 73;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.softMuteCheckBox);
            this.groupBox4.Controls.Add(this.blendCheckBox);
            this.groupBox4.Controls.Add(this.switchCheckBox);
            this.groupBox4.Controls.Add(this.deemphasisCheckBox);
            this.groupBox4.Controls.Add(this.highCutCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(426, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(142, 144);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Audio Quality";
            // 
            // softMuteCheckBox
            // 
            this.softMuteCheckBox.AutoSize = true;
            this.softMuteCheckBox.Location = new System.Drawing.Point(6, 19);
            this.softMuteCheckBox.Name = "softMuteCheckBox";
            this.softMuteCheckBox.Size = new System.Drawing.Size(71, 17);
            this.softMuteCheckBox.TabIndex = 8;
            this.softMuteCheckBox.Text = "Soft mute";
            this.softMuteCheckBox.UseVisualStyleBackColor = true;
            this.softMuteCheckBox.CheckedChanged += new System.EventHandler(this.softMuteCheckBox_CheckedChanged);
            // 
            // blendCheckBox
            // 
            this.blendCheckBox.AutoSize = true;
            this.blendCheckBox.Location = new System.Drawing.Point(6, 43);
            this.blendCheckBox.Name = "blendCheckBox";
            this.blendCheckBox.Size = new System.Drawing.Size(87, 17);
            this.blendCheckBox.TabIndex = 9;
            this.blendCheckBox.Text = "Stereo Blend";
            this.blendCheckBox.UseVisualStyleBackColor = true;
            this.blendCheckBox.CheckedChanged += new System.EventHandler(this.blendCheckBox_CheckedChanged);
            // 
            // switchCheckBox
            // 
            this.switchCheckBox.AutoSize = true;
            this.switchCheckBox.Location = new System.Drawing.Point(6, 67);
            this.switchCheckBox.Name = "switchCheckBox";
            this.switchCheckBox.Size = new System.Drawing.Size(92, 17);
            this.switchCheckBox.TabIndex = 10;
            this.switchCheckBox.Text = "Stereo Switch";
            this.switchCheckBox.UseVisualStyleBackColor = true;
            this.switchCheckBox.CheckedChanged += new System.EventHandler(this.switchCheckBox_CheckedChanged);
            // 
            // deemphasisCheckBox
            // 
            this.deemphasisCheckBox.AutoSize = true;
            this.deemphasisCheckBox.Location = new System.Drawing.Point(6, 91);
            this.deemphasisCheckBox.Name = "deemphasisCheckBox";
            this.deemphasisCheckBox.Size = new System.Drawing.Size(104, 17);
            this.deemphasisCheckBox.TabIndex = 11;
            this.deemphasisCheckBox.Text = "De-emphasis TC";
            this.deemphasisCheckBox.UseVisualStyleBackColor = true;
            this.deemphasisCheckBox.CheckedChanged += new System.EventHandler(this.deemphasisCheckBox_CheckedChanged);
            // 
            // highCutCheckBox
            // 
            this.highCutCheckBox.AutoSize = true;
            this.highCutCheckBox.Location = new System.Drawing.Point(6, 115);
            this.highCutCheckBox.Name = "highCutCheckBox";
            this.highCutCheckBox.Size = new System.Drawing.Size(67, 17);
            this.highCutCheckBox.TabIndex = 14;
            this.highCutCheckBox.Text = "High Cut";
            this.highCutCheckBox.UseVisualStyleBackColor = true;
            this.highCutCheckBox.CheckedChanged += new System.EventHandler(this.highCutCheckBox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Maximum Searches";
            // 
            // searchIntervalComboBox
            // 
            this.searchIntervalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchIntervalComboBox.FormattingEnabled = true;
            this.searchIntervalComboBox.Items.AddRange(new object[] {
            "50Hz",
            "100Hz",
            "200Hz"});
            this.searchIntervalComboBox.Location = new System.Drawing.Point(160, 63);
            this.searchIntervalComboBox.Name = "searchIntervalComboBox";
            this.searchIntervalComboBox.Size = new System.Drawing.Size(141, 21);
            this.searchIntervalComboBox.TabIndex = 70;
            this.searchIntervalComboBox.SelectedIndexChanged += new System.EventHandler(this.searchIntervalComboBox_SelectedIndexChanged);
            // 
            // numberSearches
            // 
            this.numberSearches.Location = new System.Drawing.Point(160, 90);
            this.numberSearches.Name = "numberSearches";
            this.numberSearches.Size = new System.Drawing.Size(141, 20);
            this.numberSearches.TabIndex = 69;
            this.numberSearches.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Search Interval";
            // 
            // scanForwards
            // 
            this.scanForwards.Location = new System.Drawing.Point(350, 34);
            this.scanForwards.Name = "scanForwards";
            this.scanForwards.Size = new System.Drawing.Size(37, 23);
            this.scanForwards.TabIndex = 67;
            this.scanForwards.Text = ">";
            this.scanForwards.UseVisualStyleBackColor = true;
            this.scanForwards.Click += new System.EventHandler(this.scanForwards_Click);
            // 
            // scanBackwards
            // 
            this.scanBackwards.Location = new System.Drawing.Point(307, 34);
            this.scanBackwards.Name = "scanBackwards";
            this.scanBackwards.Size = new System.Drawing.Size(37, 23);
            this.scanBackwards.TabIndex = 66;
            this.scanBackwards.Text = "<";
            this.scanBackwards.UseVisualStyleBackColor = true;
            this.scanBackwards.Click += new System.EventHandler(this.scanBackwards_Click);
            // 
            // bandwidthDropdown
            // 
            this.bandwidthDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bandwidthDropdown.FormattingEnabled = true;
            this.bandwidthDropdown.Items.AddRange(new object[] {
            "High (48kHz)",
            "Low (37kHz)"});
            this.bandwidthDropdown.Location = new System.Drawing.Point(160, 116);
            this.bandwidthDropdown.Name = "bandwidthDropdown";
            this.bandwidthDropdown.Size = new System.Drawing.Size(141, 21);
            this.bandwidthDropdown.TabIndex = 65;
            this.bandwidthDropdown.SelectedIndexChanged += new System.EventHandler(this.bandwidthDropdown_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Bandwidth";
            // 
            // scanStopQuality
            // 
            this.scanStopQuality.Location = new System.Drawing.Point(160, 37);
            this.scanStopQuality.Name = "scanStopQuality";
            this.scanStopQuality.Size = new System.Drawing.Size(141, 20);
            this.scanStopQuality.TabIndex = 63;
            this.scanStopQuality.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Scan Stop Quality";
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.Location = new System.Drawing.Point(160, 9);
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.ReadOnly = true;
            this.frequencyTextBox.Size = new System.Drawing.Size(141, 20);
            this.frequencyTextBox.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Current Frequency";
            // 
            // tabPageRDS
            // 
            this.tabPageRDS.Controls.Add(this.label14);
            this.tabPageRDS.Controls.Add(this.label13);
            this.tabPageRDS.Controls.Add(this.label12);
            this.tabPageRDS.Controls.Add(this.label11);
            this.tabPageRDS.Controls.Add(this.label10);
            this.tabPageRDS.Controls.Add(this.rdsStereoCheckBox);
            this.tabPageRDS.Controls.Add(this.dynamicCheckBox);
            this.tabPageRDS.Controls.Add(this.artificalHeadCheckBox);
            this.tabPageRDS.Controls.Add(this.typeTextBox);
            this.tabPageRDS.Controls.Add(this.rdsQualityTextBox);
            this.tabPageRDS.Controls.Add(this.compressedCheckBox);
            this.tabPageRDS.Controls.Add(this.label5);
            this.tabPageRDS.Controls.Add(this.trafficInformationTextBox);
            this.tabPageRDS.Controls.Add(this.musicCheckBox);
            this.tabPageRDS.Controls.Add(this.programmeTextBox);
            this.tabPageRDS.Controls.Add(this.firstAlternateFrequencyTextBox);
            this.tabPageRDS.Controls.Add(this.secondAlternateFrequencyTextBox);
            this.tabPageRDS.Location = new System.Drawing.Point(4, 22);
            this.tabPageRDS.Name = "tabPageRDS";
            this.tabPageRDS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRDS.Size = new System.Drawing.Size(657, 221);
            this.tabPageRDS.TabIndex = 1;
            this.tabPageRDS.Text = "RDS";
            this.tabPageRDS.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(148, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Traffic Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(148, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Programme Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(148, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Programme";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Alternate Frequency 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Alternate Frequency 1";
            // 
            // rdsStereoCheckBox
            // 
            this.rdsStereoCheckBox.AutoCheck = false;
            this.rdsStereoCheckBox.AutoSize = true;
            this.rdsStereoCheckBox.Location = new System.Drawing.Point(8, 6);
            this.rdsStereoCheckBox.Name = "rdsStereoCheckBox";
            this.rdsStereoCheckBox.Size = new System.Drawing.Size(57, 17);
            this.rdsStereoCheckBox.TabIndex = 60;
            this.rdsStereoCheckBox.Text = "Stereo";
            this.rdsStereoCheckBox.UseVisualStyleBackColor = true;
            // 
            // dynamicCheckBox
            // 
            this.dynamicCheckBox.AutoCheck = false;
            this.dynamicCheckBox.AutoSize = true;
            this.dynamicCheckBox.Location = new System.Drawing.Point(8, 110);
            this.dynamicCheckBox.Name = "dynamicCheckBox";
            this.dynamicCheckBox.Size = new System.Drawing.Size(91, 17);
            this.dynamicCheckBox.TabIndex = 61;
            this.dynamicCheckBox.Text = "Dynamic PTY";
            this.dynamicCheckBox.UseVisualStyleBackColor = true;
            // 
            // artificalHeadCheckBox
            // 
            this.artificalHeadCheckBox.AutoCheck = false;
            this.artificalHeadCheckBox.AutoSize = true;
            this.artificalHeadCheckBox.Location = new System.Drawing.Point(8, 32);
            this.artificalHeadCheckBox.Name = "artificalHeadCheckBox";
            this.artificalHeadCheckBox.Size = new System.Drawing.Size(89, 17);
            this.artificalHeadCheckBox.TabIndex = 57;
            this.artificalHeadCheckBox.Text = "Artifical Head";
            this.artificalHeadCheckBox.UseVisualStyleBackColor = true;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(265, 108);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(120, 20);
            this.typeTextBox.TabIndex = 56;
            // 
            // rdsQualityTextBox
            // 
            this.rdsQualityTextBox.Location = new System.Drawing.Point(265, 132);
            this.rdsQualityTextBox.Name = "rdsQualityTextBox";
            this.rdsQualityTextBox.ReadOnly = true;
            this.rdsQualityTextBox.Size = new System.Drawing.Size(120, 20);
            this.rdsQualityTextBox.TabIndex = 51;
            // 
            // compressedCheckBox
            // 
            this.compressedCheckBox.AutoCheck = false;
            this.compressedCheckBox.AutoSize = true;
            this.compressedCheckBox.Location = new System.Drawing.Point(8, 58);
            this.compressedCheckBox.Name = "compressedCheckBox";
            this.compressedCheckBox.Size = new System.Drawing.Size(84, 17);
            this.compressedCheckBox.TabIndex = 58;
            this.compressedCheckBox.Text = "Compressed";
            this.compressedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "RDS Quality";
            // 
            // trafficInformationTextBox
            // 
            this.trafficInformationTextBox.Location = new System.Drawing.Point(265, 82);
            this.trafficInformationTextBox.Name = "trafficInformationTextBox";
            this.trafficInformationTextBox.ReadOnly = true;
            this.trafficInformationTextBox.Size = new System.Drawing.Size(120, 20);
            this.trafficInformationTextBox.TabIndex = 55;
            // 
            // musicCheckBox
            // 
            this.musicCheckBox.AutoCheck = false;
            this.musicCheckBox.AutoSize = true;
            this.musicCheckBox.Location = new System.Drawing.Point(8, 84);
            this.musicCheckBox.Name = "musicCheckBox";
            this.musicCheckBox.Size = new System.Drawing.Size(54, 17);
            this.musicCheckBox.TabIndex = 59;
            this.musicCheckBox.Text = "Music";
            this.musicCheckBox.UseVisualStyleBackColor = true;
            // 
            // programmeTextBox
            // 
            this.programmeTextBox.Location = new System.Drawing.Point(265, 56);
            this.programmeTextBox.Name = "programmeTextBox";
            this.programmeTextBox.ReadOnly = true;
            this.programmeTextBox.Size = new System.Drawing.Size(120, 20);
            this.programmeTextBox.TabIndex = 54;
            // 
            // firstAlternateFrequencyTextBox
            // 
            this.firstAlternateFrequencyTextBox.Location = new System.Drawing.Point(265, 4);
            this.firstAlternateFrequencyTextBox.Name = "firstAlternateFrequencyTextBox";
            this.firstAlternateFrequencyTextBox.ReadOnly = true;
            this.firstAlternateFrequencyTextBox.Size = new System.Drawing.Size(120, 20);
            this.firstAlternateFrequencyTextBox.TabIndex = 52;
            // 
            // secondAlternateFrequencyTextBox
            // 
            this.secondAlternateFrequencyTextBox.Location = new System.Drawing.Point(265, 30);
            this.secondAlternateFrequencyTextBox.Name = "secondAlternateFrequencyTextBox";
            this.secondAlternateFrequencyTextBox.ReadOnly = true;
            this.secondAlternateFrequencyTextBox.Size = new System.Drawing.Size(120, 20);
            this.secondAlternateFrequencyTextBox.TabIndex = 53;
            // 
            // checkBoxPlayStop
            // 
            this.checkBoxPlayStop.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPlayStop.Location = new System.Drawing.Point(7, 254);
            this.checkBoxPlayStop.Name = "checkBoxPlayStop";
            this.checkBoxPlayStop.Size = new System.Drawing.Size(90, 23);
            this.checkBoxPlayStop.TabIndex = 61;
            this.checkBoxPlayStop.Text = "Play / Stop";
            this.checkBoxPlayStop.UseVisualStyleBackColor = true;
            this.checkBoxPlayStop.CheckedChanged += new System.EventHandler(this.checkBoxPlayStop_CheckedChanged);
            // 
            // checkBoxRDS
            // 
            this.checkBoxRDS.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxRDS.Checked = true;
            this.checkBoxRDS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRDS.Location = new System.Drawing.Point(103, 254);
            this.checkBoxRDS.Name = "checkBoxRDS";
            this.checkBoxRDS.Size = new System.Drawing.Size(90, 23);
            this.checkBoxRDS.TabIndex = 62;
            this.checkBoxRDS.Text = "RDS";
            this.checkBoxRDS.UseVisualStyleBackColor = true;
            this.checkBoxRDS.CheckedChanged += new System.EventHandler(this.checkBoxRDS_CheckedChanged);
            // 
            // timerInfoUpdate
            // 
            this.timerInfoUpdate.Interval = 2000;
            this.timerInfoUpdate.Tick += new System.EventHandler(this.timerInfoUpdate_Tick);
            // 
            // progressBarSQ
            // 
            this.progressBarSQ.Location = new System.Drawing.Point(530, 260);
            this.progressBarSQ.Name = "progressBarSQ";
            this.progressBarSQ.Size = new System.Drawing.Size(122, 17);
            this.progressBarSQ.TabIndex = 63;
            // 
            // TrackbarMaster
            // 
            this.TrackbarMaster.LargeChange = 20;
            this.TrackbarMaster.Location = new System.Drawing.Point(465, 3);
            this.TrackbarMaster.Maximum = 100;
            this.TrackbarMaster.Name = "TrackbarMaster";
            this.TrackbarMaster.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackbarMaster.Size = new System.Drawing.Size(45, 212);
            this.TrackbarMaster.SmallChange = 5;
            this.TrackbarMaster.TabIndex = 82;
            this.TrackbarMaster.TickFrequency = 10;
            this.TrackbarMaster.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackbarMaster.Scroll += new System.EventHandler(this.TrackbarMaster_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 281);
            this.Controls.Add(this.progressBarSQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signalLockCheckBox);
            this.Controls.Add(this.checkBoxRDS);
            this.Controls.Add(this.checkBoxPlayStop);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Radio App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPageRadio.ResumeLayout(false);
            this.tabPageRadio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStereo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).EndInit();
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            this.tabPageAdvanced.ResumeLayout(false);
            this.tabPageAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorThreshold)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSearches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanStopQuality)).EndInit();
            this.tabPageRDS.ResumeLayout(false);
            this.tabPageRDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox signalLockCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAdvanced;
        private System.Windows.Forms.Button updateRdsControl;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown errorThreshold;
        private System.Windows.Forms.CheckBox errorCorrectionCheckBox;
        private System.Windows.Forms.Button setFrequencyButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox setFrequencyTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox softMuteCheckBox;
        private System.Windows.Forms.CheckBox blendCheckBox;
        private System.Windows.Forms.CheckBox switchCheckBox;
        private System.Windows.Forms.CheckBox deemphasisCheckBox;
        private System.Windows.Forms.CheckBox highCutCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox searchIntervalComboBox;
        private System.Windows.Forms.NumericUpDown numberSearches;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button scanForwards;
        private System.Windows.Forms.Button scanBackwards;
        private System.Windows.Forms.ComboBox bandwidthDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown scanStopQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frequencyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageRDS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox rdsStereoCheckBox;
        private System.Windows.Forms.CheckBox dynamicCheckBox;
        private System.Windows.Forms.CheckBox artificalHeadCheckBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox rdsQualityTextBox;
        private System.Windows.Forms.CheckBox compressedCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox trafficInformationTextBox;
        private System.Windows.Forms.CheckBox musicCheckBox;
        private System.Windows.Forms.TextBox programmeTextBox;
        private System.Windows.Forms.TextBox firstAlternateFrequencyTextBox;
        private System.Windows.Forms.TextBox secondAlternateFrequencyTextBox;
        private System.Windows.Forms.TabPage tabPageRadio;
        private System.Windows.Forms.TrackBar trackBarFrequency;
        private System.Windows.Forms.CheckBox checkBoxPlayStop;
        private System.Windows.Forms.CheckBox checkBoxRDS;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.Button btnScanForward;
        private System.Windows.Forms.Button btnScanBack;
        private System.Windows.Forms.Timer timerInfoUpdate;
        private Owf.Controls.DigitalDisplayControl digitalDisplayFrequency;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private System.Windows.Forms.Button btnStation10;
        private System.Windows.Forms.Button btnStation9;
        private System.Windows.Forms.Button btnStation8;
        private System.Windows.Forms.Button btnStation7;
        private System.Windows.Forms.Button btnStation6;
        private System.Windows.Forms.Button btnStation5;
        private System.Windows.Forms.Button btnStation4;
        private System.Windows.Forms.Button btnStation3;
        private System.Windows.Forms.Button btnStation2;
        private System.Windows.Forms.Button btnStation1;
        private System.Windows.Forms.ProgressBar progressBarSQ;
        private System.Windows.Forms.PictureBox pictureBoxStereo;
        private System.Windows.Forms.PictureBox pictureBoxRDS;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.TrackBar TrackbarMaster;
    }
}

