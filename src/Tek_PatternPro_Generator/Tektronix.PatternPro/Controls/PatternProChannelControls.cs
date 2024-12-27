using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tektronix.PatternPro;

namespace Tek_PatternPro_Generator
{
    public partial class PatternProChannelControls : UserControl
    {
        private static Color[] channelColors = {
            Color.FromArgb(244, 239, 4),
            Color.FromArgb(8, 230, 230),
            Color.FromArgb(245, 4, 242),
            Color.FromArgb(9, 243, 0)
        };

        private PatternProChannel patternProChannel;
        private bool outputEnabled = false;

        public PatternProChannelControls()
        {
            InitializeComponent();

            cmbxPRBSPat.Items.AddRange(new object[] {PRBSPattern.PRBS7,
                PRBSPattern.PRBS9,
                PRBSPattern.PRBS11,
                PRBSPattern.PRBS15,
                PRBSPattern.PRBS23,
                PRBSPattern.PRBS31 });

        }


        /// <summary>
        /// The PatternPro Generator the channel belongs to.
        /// </summary>
        public PatternProGenerator PatternProGenerator
        {
            get => patternProChannel.ParrentGenerator;
        }

        /// <summary>
        /// The PatternProChannel that this control will operate.
        /// </summary>
        public PatternProChannel PatternProChannel
        {
            get => patternProChannel;
            set
            {
                patternProChannel = value;
                if (value == null)
                {
                    pnlChColor.BackColor = channelColors[0];
                    lblChLabel.Text = "Channel";
                }
                else
                {
                    //int idx = patternProChannel.ParrentGenerator.Channels.FindIndex(x => x == value);
                    int idx = int.Parse(patternProChannel.ChannelNumber) - 1;
                    pnlChColor.BackColor = channelColors[idx];
                    lblChLabel.Text = $"Channel {value._chNum}";
                }
                this.RefreshControlValues();
            }
        }

        public bool OutputEnabled
        {
            get => outputEnabled;
            set
            {
                if (patternProChannel != null)
                {
                    outputEnabled = value;
                    patternProChannel.OutputEnabled = outputEnabled;
                    cmdOutputEnableDisable.ImageIndex = outputEnabled ? 1 : 0;
                }
            }
        }

        /// <summary>
        /// Queries the instrument for the currently set values and updates the controls to match.
        /// </summary>
        public void RefreshControlValues()
        {
            if (this.patternProChannel != null)
            {
                // Query the values and update the controls
                var pattType = PatternProChannel.PatternType;
                if (pattType == DigitalPatternType.PRBS)
                {
                    rdbtnPattPRBS.Select();
                    lblPattLenVal.Text = PatternProChannel.PatternPRBSLength.ToString();
                }
                else
                {
                    rdbtnPattData.Select();
                    lblPattLenVal.Text = PatternProChannel.PatternLength.ToString();
                }
                cmbxPRBSPat.Text = PatternProChannel.PatternPRBS.ToString();

                outputEnabled = PatternProChannel.OutputEnabled;
                cmdOutputEnableDisable.ImageIndex = outputEnabled ? 1 : 0;

                // Update voltages
                nudAmpPos.Value = (decimal)PatternProChannel.VoltageAmplitudePositive;
                nudAmpNeg.Value = (decimal)PatternProChannel.VoltageAmplitudeNegative;

                nudOffsetPos.Value = (decimal)PatternProChannel.VoltageOffsetPositive;
                nudOffsetNeg.Value = (decimal)PatternProChannel.VoltageOffsetNegative;

                nudTerminationPos.Value = (decimal)PatternProChannel.VoltageTerminationPositive;
                nudTerminationNeg.Value = (decimal)PatternProChannel.VoltageTerminationNegative;

                cbxLinkVoltage.Checked = PatternProChannel.VoltageLink;
            }
            else // Set to defaults
            {
                rdbtnPattPRBS.Checked = true;
                rdbtnPattData.Checked = false;
                cmbxPRBSPat.SelectedIndex = 0;
                lblPattLenVal.Text = "7";
                cmdOutputEnableDisable.ImageIndex = 0;
                this.outputEnabled = false;
                cbxLinkVoltage.Checked = false;
                nudAmpPos.Value = 0.5M;
                nudAmpNeg.Value = 0.5M;
                nudOffsetPos.Value = 0;
                nudOffsetNeg.Value = 0;
                nudTerminationPos.Value = 0;
                nudTerminationNeg.Value = 0;
                nudBitShiftBits.Value = 1;
            }
        }


        private void PPG_Channel_Controls_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdOutputEnableDisable_Click(object sender, EventArgs e)
        {
            if (outputEnabled) // Then turn off
            {
                PatternProChannel.OutputEnabled = false;
                cmdOutputEnableDisable.ImageIndex = 0;
            }
            else // turn on
            {
                PatternProChannel.OutputEnabled = true;
                cmdOutputEnableDisable.ImageIndex = 1;
            }
            outputEnabled = !outputEnabled;
        }

        private void cmbxPRBSPat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PatternProChannel != null)
            {
                PatternProChannel.PatternPRBS = (PRBSPattern)cmbxPRBSPat.SelectedItem;
                lblPattLenVal.Text = patternProChannel.PatternPRBSLength.ToString();
            }
        }

        private void cbxLinkVoltage_CheckedChanged(object sender, EventArgs e)
        {
            // Link/Unlink Pos & Neg

            if (cbxLinkVoltage.Checked) // Link
            {
                // Make Negative match Positive
                PatternProChannel.VoltageAmplitudeNegative = PatternProChannel.VoltageAmplitudePositive;
                PatternProChannel.VoltageOffsetNegative = PatternProChannel.VoltageOffsetPositive;
                PatternProChannel.VoltageTerminationNegative = PatternProChannel.VoltageTerminationPositive;

                PatternProChannel.VoltageLink = true;

                nudAmpNeg.Enabled = false;
                nudOffsetNeg.Enabled = false;
                nudTerminationNeg.Enabled = false;
            }
            else // Unlink
            {
                PatternProChannel.VoltageLink = false;

                nudAmpNeg.Enabled = true;
                nudOffsetNeg.Enabled = true;
                nudTerminationNeg.Enabled = true;
            }
        }

        private void cmdInjectError_Click(object sender, EventArgs e)
        {
            PatternProChannel.SingleError();
        }

        private void cmdBitShift_Click(object sender, EventArgs e)
        {
            PatternProChannel.PatternBitShift((int)nudBitShiftBits.Value);
        }

        private void nudAmpPos_ValueChanged(object sender, EventArgs e)
        {
            patternProChannel.VoltageAmplitudePositive = (float)nudAmpPos.Value;

            if (cbxLinkVoltage.Checked) { nudAmpNeg.Value = nudAmpPos.Value; }
        }

        private void nudAmpNeg_ValueChanged(object sender, EventArgs e)
        {
            if (!cbxLinkVoltage.Checked)
            {
                patternProChannel.VoltageAmplitudeNegative = (float)nudAmpNeg.Value;
            }
        }

        private void nudOffsetPos_ValueChanged(object sender, EventArgs e)
        {
            patternProChannel.VoltageOffsetPositive = (float)nudOffsetPos.Value;

            if (cbxLinkVoltage.Checked) { nudOffsetNeg.Value = nudOffsetPos.Value; }
        }

        private void nudOffsetNeg_ValueChanged(object sender, EventArgs e)
        {
            if (!cbxLinkVoltage.Checked)
            {
                patternProChannel.VoltageOffsetNegative = (float)nudOffsetNeg.Value;
            }
        }

        private void nudTerminationPos_ValueChanged(object sender, EventArgs e)
        {
            patternProChannel.VoltageTerminationPositive = (float)nudTerminationPos.Value;

            if (cbxLinkVoltage.Checked) { nudTerminationNeg.Value = nudTerminationPos.Value; }
        }

        private void nudTerminationNeg_ValueChanged(object sender, EventArgs e)
        {
            if (!cbxLinkVoltage.Checked)
            {
                patternProChannel.VoltageTerminationNegative = (float)nudTerminationNeg.Value;
            }
        }
    }
}
