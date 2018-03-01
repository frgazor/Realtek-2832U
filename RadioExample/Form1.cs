using System;
using System.Windows.Forms;
using RadioLib;

namespace RadioExample
{
    public partial class Form1 : Form
    {
        private FmRadioGraph fmRadioGraph;
        private FmRadio controller;

        private Interval currentInterval;
        private bool rdsEnabled = true;

        private int smallChangeValue = 50;
        private int trackValue;
        private bool blockRecursion = false;

        public Form1()
        {
            InitializeComponent();
            try
            {
                int frequency = Properties.Settings.Default.selectedFrequency;
                trackBarFrequency.Value = frequency;
                setFrequencyLabel();

                fmRadioGraph = new FmRadioGraph();
                controller = fmRadioGraph.RadioControl;
                SetCheckboxState();

                searchIntervalComboBox.SelectedIndex = 1;
                bandwidthDropdown.SelectedIndex = 0;
                controller.AudioSampleRate = SampleRate.High;

                rdsEnabled = true;
                controller.EnableRadioData = true;

                controller.Frequency = frequency;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            lblStationName.Text = "";
        }

        private void SetCheckboxState()
        {
            var quality = controller.QualityControl;
            if (quality.HasFlag(QualityControl.SoftMute))
                softMuteCheckBox.Checked = true;
            if (quality.HasFlag(QualityControl.HighCutControl))
                highCutCheckBox.Checked = true;
            if (quality.HasFlag(QualityControl.StereoBlend))
                blendCheckBox.Checked = true;
            if (quality.HasFlag(QualityControl.StereoSwitch))
                switchCheckBox.Checked = true;
        }

        private void deemphasisCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            controller.Deemphasis = deemphasisCheckBox.Checked ? Deemphasis.High : Deemphasis.Low;
        }

        private void softMuteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetFlag(QualityControl.SoftMute, softMuteCheckBox.Checked);
        }

        private void blendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetFlag(QualityControl.StereoBlend, blendCheckBox.Checked);
        }

        private void switchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetFlag(QualityControl.StereoSwitch, switchCheckBox.Checked);
        }

        private void highCutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetFlag(QualityControl.HighCutControl, highCutCheckBox.Checked);
        }

        private void SetFlag(QualityControl flag, bool isChecked)
        {
            if (isChecked)
                controller.QualityControl = controller.QualityControl | flag;
            else
                controller.QualityControl = controller.QualityControl & ~flag;
        }

        private void scanForwards_Click(object sender, EventArgs e)
        {
            var currentFrequency = 87500; //controller.TunerRange.LowRange;
            if (frequencyTextBox.Text != string.Empty)
                currentFrequency = int.Parse(frequencyTextBox.Text) + (int) currentInterval;
            lblStationName.Text = "scanning...";
            var result = controller.Scan(currentFrequency, currentInterval, Direction.Forwards, (uint)scanStopQuality.Value, (int)numberSearches.Value);
            if (result.HasValue)
            {
                frequencyTextBox.Text = result.Value.Frequency.ToString();
                signalQualityTextBox.Text = result.Value.Quality.ToString();
                controller.Frequency = result.Value.Frequency;
                trackBarFrequency.Value = result.Value.Frequency;
                setFrequencyLabel();
            }
            else
            {
                MessageBox.Show("Scan found no results.\r\nAdjust scan quality or number of searches.", "Scan Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            lblStationName.Text = "";
        }

        private void scanBackwards_Click(object sender, EventArgs e)
        {
            var currentFrequency = 108000; //controller.TunerRange.HighRange;
            if (frequencyTextBox.Text != string.Empty)
                currentFrequency = int.Parse(frequencyTextBox.Text) + (int)currentInterval;
            lblStationName.Text = "scanning...";
            var result = controller.Scan(currentFrequency, currentInterval, Direction.Backwards, (uint)scanStopQuality.Value, (int)numberSearches.Value);
            if (result.HasValue)
            {
                frequencyTextBox.Text = result.Value.Frequency.ToString();
                signalQualityTextBox.Text = result.Value.Quality.ToString();
                controller.Frequency = result.Value.Frequency;
                trackBarFrequency.Value = result.Value.Frequency;
                setFrequencyLabel();
            }
            else
            {
                MessageBox.Show("Scan found no results.\r\nAdjust scan quality or number of searches.", "Scan Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            lblStationName.Text = "";
        }

        private void bandwidthDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bandwidthDropdown.SelectedIndex == 0)
                controller.AudioSampleRate = SampleRate.High;
            else
                controller.AudioSampleRate = SampleRate.Low;
        }

        private void UpdateRange()
        {
            var range = controller.TunerRange;
            lowestFrequencyTextBox.Text = range.LowRange.ToString();
            highestFrequencyTextBox.Text = range.HighRange.ToString();
        }

        private void UpdateRadioData()
        {
            if (!rdsEnabled)
                return;

            controller.RadioData.Update();
            var radioData = controller.RadioData;
            firstAlternateFrequencyTextBox.Text = radioData.AlternateFrequency1;
            secondAlternateFrequencyTextBox.Text = radioData.AlternateFrequency2;
            artificalHeadCheckBox.Checked = radioData.ArtificalHead;
            compressedCheckBox.Checked = radioData.Compressed;
            musicCheckBox.Checked = radioData.IsMusic;
            rdsStereoCheckBox.Checked = radioData.IsStereo;
            programmeTextBox.Text = radioData.ProgrammeService;
            lblStationName.Text = radioData.ProgrammeService;
            trafficInformationTextBox.Text = radioData.TrafficIndicator;
            typeTextBox.Text = radioData.Type.ToString();
            dynamicCheckBox.Checked = radioData.DynamicProgrammeType;

            var sync = controller.RadioDataControl;
            errorCorrectionCheckBox.Checked = sync.ErrorCorrection;
            errorThreshold.Text = sync.Threshold.ToString();
        }

        private void searchIntervalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (searchIntervalComboBox.SelectedIndex)
            {
                case 0:
                    currentInterval = Interval.Fifty;
                    break;
                case 1:
                    currentInterval = Interval.Hundred;
                    break;
                case 2:
                    currentInterval = Interval.TwoHundred;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void setFrequencyButton_Click(object sender, EventArgs e)
        {
            int setFrequency;
            if (!int.TryParse(setFrequencyTextBox.Text, out setFrequency))
            {
                MessageBox.Show("Enter frequency in numerical form", "Unable to set frequency", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            controller.Frequency = setFrequency;
            trackBarFrequency.Value = setFrequency;
            setFrequencyLabel();
        }

        private void updateRdsControl_Click(object sender, EventArgs e)
        {
            if (!rdsEnabled)
                return;
            var control = new RadioDataControl(errorCorrectionCheckBox.Checked, (uint) errorThreshold.Value);
            controller.RadioDataControl = control;
        }

        private void trackBarFrequency_Scroll(object sender, EventArgs e)
        {
            lblStationName.Text = "";
            setFrequencyLabel();
        }

        private void trackBarFrequency_ValueChanged(object sender, EventArgs e)
        {
            if (blockRecursion) return;

            trackValue = trackBarFrequency.Value;

            if (trackValue % smallChangeValue != 0)
            {
                trackValue = (trackValue / smallChangeValue) * smallChangeValue;

                blockRecursion = true;

                trackBarFrequency.Value = trackValue;

                blockRecursion = false;

                setFrequencyLabel();
            }

        }

        private void setFrequencyLabel()
        {
            String freq = "" + trackBarFrequency.Value;
            int freqSize = freq.Length;
            if (freqSize == 5)
            {
                freq = freq.Substring(0, 2) + "." + freq.Substring(2, 3);
            }
            else
            {
                freq = freq.Substring(0, 3) + "." + freq.Substring(3, 3);
            }
            if (trackBarFrequency.Value < 100000)
                freq = "0" + freq;
            digitalDisplayFrequency.DigitText = freq;
        }

        private void checkBoxPlayStop_CheckedChanged(object sender, EventArgs e)
        {
            if(((CheckBox)sender).Checked)
            {
                controller.Frequency = controller.Frequency;
                fmRadioGraph.Play();
                timerInfoUpdate.Start();
            }
            else
            {
                fmRadioGraph.Stop();
                timerInfoUpdate.Stop();
            }
        }

        private void checkBoxRDS_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                rdsEnabled = true;
                controller.EnableRadioData = true;
            }
            else
            {
                rdsEnabled = false;
                controller.EnableRadioData = false;
                lblStationName.Text = "";
            }
        }

        private void trackBarFrequency_MouseUp(object sender, MouseEventArgs e)
        {
            controller.Frequency = trackBarFrequency.Value;
            lblStationName.Text = "";
        }

        private void timerInfoUpdate_Tick(object sender, EventArgs e)
        {
            if (checkBoxPlayStop.Checked)
                if (checkBoxRDS.Checked)
                    updateInfos();
        }

        private void updateInfos()
        {
            var information = controller.AudioInformation;
            sampleRateTextBox.Text = information.SampleRate.ToString();
            bitRateTextBox.Text = information.BitsPerSample.ToString();
            audioStereoCheckBox.Checked = information.IsStereo;

            isStereoCheckBox.Checked = controller.IsStereo;
            rdsSyncCheckBox.Checked = controller.RadioDataSync;
            signalLockCheckBox.Checked = controller.SignalLock;

            signalQualityTextBox.Text = controller.SignalQuality.ToString();
            rdsQualityTextBox.Text = controller.RadioDataQuality.ToString();

            UpdateRadioData();
            UpdateRange();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.selectedFrequency = trackBarFrequency.Value;
            Properties.Settings.Default.Save();
        }


        private void btnStation1_Click(object sender, EventArgs e)
        {
            if(checkBoxSave.Checked)
            {
                Properties.Settings.Default.station1 = trackBarFrequency.Value;
                Properties.Settings.Default.Save();
                checkBoxSave.Checked = false;
            }
            else
            {
                lblStationName.Text = "";
                controller.Frequency = Properties.Settings.Default.station1;
                trackBarFrequency.Value = Properties.Settings.Default.station1;
                setFrequencyLabel();
            }
        }

        private void btnStation2_Click(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked)
            {
                Properties.Settings.Default.station2 = trackBarFrequency.Value;
                Properties.Settings.Default.Save();
                checkBoxSave.Checked = false;
            }
            else
            {
                lblStationName.Text = "";
                controller.Frequency = Properties.Settings.Default.station2;
                trackBarFrequency.Value = Properties.Settings.Default.station2;
                setFrequencyLabel();
            }
        }

        private void btnStation3_Click(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked)
            {
                Properties.Settings.Default.station3 = trackBarFrequency.Value;
                Properties.Settings.Default.Save();
                checkBoxSave.Checked = false;
            }
            else
            {
                lblStationName.Text = "";
                controller.Frequency = Properties.Settings.Default.station3;
                trackBarFrequency.Value = Properties.Settings.Default.station3;
                setFrequencyLabel();
            }
        }

        private void btnStation4_Click(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked)
            {
                Properties.Settings.Default.station4 = trackBarFrequency.Value;
                Properties.Settings.Default.Save();
                checkBoxSave.Checked = false;
            }
            else
            {
                lblStationName.Text = "";
                controller.Frequency = Properties.Settings.Default.station4;
                trackBarFrequency.Value = Properties.Settings.Default.station4;
                setFrequencyLabel();
            }
        }

        private void btnStation5_Click(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked)
            {
                Properties.Settings.Default.station5 = trackBarFrequency.Value;
                Properties.Settings.Default.Save();
                checkBoxSave.Checked = false;
            }
            else
            {
                lblStationName.Text = "";
                controller.Frequency = Properties.Settings.Default.station5;
                trackBarFrequency.Value = Properties.Settings.Default.station5;
                setFrequencyLabel();
            }
        }

        private void btnStation6_Click(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked)
            {
                Properties.Settings.Default.station6 = trackBarFrequency.Value;
                Properties.Settings.Default.Save();
                checkBoxSave.Checked = false;
            }
            else
            {
                lblStationName.Text = "";
                controller.Frequency = Properties.Settings.Default.station6;
                trackBarFrequency.Value = Properties.Settings.Default.station6;
                setFrequencyLabel();
            }
        }

        private void btnStation7_Click(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked)
            {
                Properties.Settings.Default.station7 = trackBarFrequency.Value;
                Properties.Settings.Default.Save();
                checkBoxSave.Checked = false;
            }
            else
            {
                lblStationName.Text = "";
                controller.Frequency = Properties.Settings.Default.station7;
                trackBarFrequency.Value = Properties.Settings.Default.station7;
                setFrequencyLabel();
            }
        }

        private void btnStation8_Click(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked)
            {
                Properties.Settings.Default.station8 = trackBarFrequency.Value;
                Properties.Settings.Default.Save();
                checkBoxSave.Checked = false;
            }
            else
            {
                lblStationName.Text = "";
                controller.Frequency = Properties.Settings.Default.station8;
                trackBarFrequency.Value = Properties.Settings.Default.station8;
                setFrequencyLabel();
            }
        }

        private void btnStation9_Click(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked)
            {
                Properties.Settings.Default.station9 = trackBarFrequency.Value;
                Properties.Settings.Default.Save();
                checkBoxSave.Checked = false;
            }
            else
            {
                lblStationName.Text = "";
                controller.Frequency = Properties.Settings.Default.station9;
                trackBarFrequency.Value = Properties.Settings.Default.station9;
                setFrequencyLabel();
            }
        }

        private void btnStation10_Click(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked)
            {
                Properties.Settings.Default.station10 = trackBarFrequency.Value;
                Properties.Settings.Default.Save();
                checkBoxSave.Checked = false;
            }
            else
            {
                lblStationName.Text = "";
                controller.Frequency = Properties.Settings.Default.station10;
                trackBarFrequency.Value = Properties.Settings.Default.station10;
                setFrequencyLabel();
            }
        }
    }
}
