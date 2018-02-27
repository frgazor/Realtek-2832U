namespace RadioExample
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
            this.signalLockCheckBox = new System.Windows.Forms.CheckBox();
            this.signalQualityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isStereoCheckBox = new System.Windows.Forms.CheckBox();
            this.rdsSyncCheckBox = new System.Windows.Forms.CheckBox();
            this.audioStereoCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sampleRateTextBox = new System.Windows.Forms.TextBox();
            this.bitRateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lowestFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.highestFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageRadio = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStationName = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.trackBarFrequency = new System.Windows.Forms.TrackBar();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
            this.tabPageAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorThreshold)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSearches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanStopQuality)).BeginInit();
            this.tabPageRDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // signalLockCheckBox
            // 
            this.signalLockCheckBox.AutoCheck = false;
            this.signalLockCheckBox.AutoSize = true;
            this.signalLockCheckBox.Location = new System.Drawing.Point(6, 19);
            this.signalLockCheckBox.Name = "signalLockCheckBox";
            this.signalLockCheckBox.Size = new System.Drawing.Size(82, 17);
            this.signalLockCheckBox.TabIndex = 15;
            this.signalLockCheckBox.Text = "Signal Lock";
            this.signalLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // signalQualityTextBox
            // 
            this.signalQualityTextBox.Location = new System.Drawing.Point(97, 94);
            this.signalQualityTextBox.Name = "signalQualityTextBox";
            this.signalQualityTextBox.ReadOnly = true;
            this.signalQualityTextBox.Size = new System.Drawing.Size(123, 20);
            this.signalQualityTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Signal Quality";
            // 
            // isStereoCheckBox
            // 
            this.isStereoCheckBox.AutoCheck = false;
            this.isStereoCheckBox.AutoSize = true;
            this.isStereoCheckBox.Location = new System.Drawing.Point(6, 44);
            this.isStereoCheckBox.Name = "isStereoCheckBox";
            this.isStereoCheckBox.Size = new System.Drawing.Size(57, 17);
            this.isStereoCheckBox.TabIndex = 20;
            this.isStereoCheckBox.Text = "Stereo";
            this.isStereoCheckBox.UseVisualStyleBackColor = true;
            // 
            // rdsSyncCheckBox
            // 
            this.rdsSyncCheckBox.AutoCheck = false;
            this.rdsSyncCheckBox.AutoSize = true;
            this.rdsSyncCheckBox.Location = new System.Drawing.Point(6, 71);
            this.rdsSyncCheckBox.Name = "rdsSyncCheckBox";
            this.rdsSyncCheckBox.Size = new System.Drawing.Size(76, 17);
            this.rdsSyncCheckBox.TabIndex = 21;
            this.rdsSyncCheckBox.Text = "RDS Sync";
            this.rdsSyncCheckBox.UseVisualStyleBackColor = true;
            // 
            // audioStereoCheckBox
            // 
            this.audioStereoCheckBox.AutoCheck = false;
            this.audioStereoCheckBox.AutoSize = true;
            this.audioStereoCheckBox.Location = new System.Drawing.Point(97, 73);
            this.audioStereoCheckBox.Name = "audioStereoCheckBox";
            this.audioStereoCheckBox.Size = new System.Drawing.Size(57, 17);
            this.audioStereoCheckBox.TabIndex = 22;
            this.audioStereoCheckBox.Text = "Stereo";
            this.audioStereoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sample Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Bits per Sample";
            // 
            // sampleRateTextBox
            // 
            this.sampleRateTextBox.Location = new System.Drawing.Point(97, 17);
            this.sampleRateTextBox.Name = "sampleRateTextBox";
            this.sampleRateTextBox.ReadOnly = true;
            this.sampleRateTextBox.Size = new System.Drawing.Size(123, 20);
            this.sampleRateTextBox.TabIndex = 25;
            // 
            // bitRateTextBox
            // 
            this.bitRateTextBox.Location = new System.Drawing.Point(97, 43);
            this.bitRateTextBox.Name = "bitRateTextBox";
            this.bitRateTextBox.ReadOnly = true;
            this.bitRateTextBox.Size = new System.Drawing.Size(123, 20);
            this.bitRateTextBox.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.signalLockCheckBox);
            this.groupBox1.Controls.Add(this.isStereoCheckBox);
            this.groupBox1.Controls.Add(this.rdsSyncCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.signalQualityTextBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 125);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signal Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.audioStereoCheckBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.bitRateTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.sampleRateTextBox);
            this.groupBox2.Location = new System.Drawing.Point(236, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 103);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio Information";
            // 
            // lowestFrequencyTextBox
            // 
            this.lowestFrequencyTextBox.Location = new System.Drawing.Point(571, 251);
            this.lowestFrequencyTextBox.Name = "lowestFrequencyTextBox";
            this.lowestFrequencyTextBox.ReadOnly = true;
            this.lowestFrequencyTextBox.Size = new System.Drawing.Size(71, 20);
            this.lowestFrequencyTextBox.TabIndex = 50;
            // 
            // highestFrequencyTextBox
            // 
            this.highestFrequencyTextBox.Location = new System.Drawing.Point(570, 277);
            this.highestFrequencyTextBox.Name = "highestFrequencyTextBox";
            this.highestFrequencyTextBox.ReadOnly = true;
            this.highestFrequencyTextBox.Size = new System.Drawing.Size(72, 20);
            this.highestFrequencyTextBox.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(468, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Lowest Frequency";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(468, 277);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 53;
            this.label17.Text = "Highest Frequency";
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
            this.tabPageRadio.Controls.Add(this.button2);
            this.tabPageRadio.Controls.Add(this.button1);
            this.tabPageRadio.Controls.Add(this.lblStationName);
            this.tabPageRadio.Controls.Add(this.lblFrequency);
            this.tabPageRadio.Controls.Add(this.trackBarFrequency);
            this.tabPageRadio.Location = new System.Drawing.Point(4, 22);
            this.tabPageRadio.Name = "tabPageRadio";
            this.tabPageRadio.Size = new System.Drawing.Size(651, 221);
            this.tabPageRadio.TabIndex = 2;
            this.tabPageRadio.Text = "Radio";
            this.tabPageRadio.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 45);
            this.button2.TabIndex = 68;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.scanForwards_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 45);
            this.button1.TabIndex = 67;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.scanBackwards_Click);
            // 
            // lblStationName
            // 
            this.lblStationName.BackColor = System.Drawing.Color.Black;
            this.lblStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStationName.Location = new System.Drawing.Point(3, 0);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(645, 43);
            this.lblStationName.TabIndex = 2;
            this.lblStationName.Text = "Station name";
            this.lblStationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFrequency
            // 
            this.lblFrequency.BackColor = System.Drawing.Color.Black;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.lblFrequency.ForeColor = System.Drawing.Color.Lime;
            this.lblFrequency.Location = new System.Drawing.Point(3, 43);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(645, 127);
            this.lblFrequency.TabIndex = 1;
            this.lblFrequency.Text = "87.500";
            this.lblFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarFrequency
            // 
            this.trackBarFrequency.LargeChange = 100;
            this.trackBarFrequency.Location = new System.Drawing.Point(52, 173);
            this.trackBarFrequency.Maximum = 108000;
            this.trackBarFrequency.Minimum = 87500;
            this.trackBarFrequency.Name = "trackBarFrequency";
            this.trackBarFrequency.Size = new System.Drawing.Size(547, 45);
            this.trackBarFrequency.SmallChange = 50;
            this.trackBarFrequency.TabIndex = 0;
            this.trackBarFrequency.TickFrequency = 1000;
            this.trackBarFrequency.Value = 87500;
            this.trackBarFrequency.Scroll += new System.EventHandler(this.trackBarFrequency_Scroll);
            this.trackBarFrequency.ValueChanged += new System.EventHandler(this.trackBarFrequency_ValueChanged);
            this.trackBarFrequency.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarFrequency_MouseUp);
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
            this.tabPageAdvanced.Size = new System.Drawing.Size(651, 221);
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
            this.tabPageRDS.Size = new System.Drawing.Size(651, 221);
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
            this.checkBoxPlayStop.Location = new System.Drawing.Point(4, 385);
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
            this.checkBoxRDS.Location = new System.Drawing.Point(101, 385);
            this.checkBoxRDS.Name = "checkBoxRDS";
            this.checkBoxRDS.Size = new System.Drawing.Size(90, 23);
            this.checkBoxRDS.TabIndex = 62;
            this.checkBoxRDS.Text = "RDS ON / OFF";
            this.checkBoxRDS.UseVisualStyleBackColor = true;
            this.checkBoxRDS.CheckedChanged += new System.EventHandler(this.checkBoxRDS_CheckedChanged);
            // 
            // timerInfoUpdate
            // 
            this.timerInfoUpdate.Interval = 2000;
            this.timerInfoUpdate.Tick += new System.EventHandler(this.timerInfoUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 414);
            this.Controls.Add(this.checkBoxRDS);
            this.Controls.Add(this.checkBoxPlayStop);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.highestFrequencyTextBox);
            this.Controls.Add(this.lowestFrequencyTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Radio Test App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageRadio.ResumeLayout(false);
            this.tabPageRadio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).EndInit();
            this.tabPageAdvanced.ResumeLayout(false);
            this.tabPageAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorThreshold)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSearches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanStopQuality)).EndInit();
            this.tabPageRDS.ResumeLayout(false);
            this.tabPageRDS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox signalLockCheckBox;
        private System.Windows.Forms.TextBox signalQualityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isStereoCheckBox;
        private System.Windows.Forms.CheckBox rdsSyncCheckBox;
        private System.Windows.Forms.CheckBox audioStereoCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sampleRateTextBox;
        private System.Windows.Forms.TextBox bitRateTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lowestFrequencyTextBox;
        private System.Windows.Forms.TextBox highestFrequencyTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
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
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.CheckBox checkBoxPlayStop;
        private System.Windows.Forms.CheckBox checkBoxRDS;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerInfoUpdate;
    }
}

