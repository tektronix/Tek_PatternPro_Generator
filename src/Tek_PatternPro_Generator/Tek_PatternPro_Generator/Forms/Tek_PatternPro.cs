using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ivi.Visa;
using Tektronix.PatternPro;


namespace Tek_PatternPro_Generator
{
    public partial class Tek_PatternPro : Form
    {
        private static System.Drawing.Size sizeOneTwoChannel = new System.Drawing.Size(610, 470);
        private static System.Drawing.Size sizeFourChannel = new System.Drawing.Size(610, 785);

        internal PatternProGenerator ppg = null;
        public Tek_PatternPro()
        {
            InitializeComponent();
        }

        private void Tek_PPG_Control_Load(object sender, EventArgs e)
        {
            refreshVisaResource();

            if (cmbxVisaRsrcAddr.Items.Count > 0)
            {
                cmbxVisaRsrcAddr.SelectedIndex = 0;
            }
        }

        private void refreshVisaResource()
        {
            try
            {
                IEnumerable<string> resources = GlobalResourceManager.Find("USB?*INSTR");
                foreach (string resource in resources)
                {
                    cmbxVisaRsrcAddr.Items.Add(resource);
                }
            }
            catch { }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            refreshVisaResource();
        }

        private void cmdConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (ppg == null) // Then connect
            { 
                string visaRsrcAddr = cmbxVisaRsrcAddr.Text.Trim();
                try
                {
                    ppg = new PatternProGenerator(visaRsrcAddr);

                    // Put in one channel control per available channel
                    this.flowLayoutPanelPPGChannels.Controls.Clear();

                    if (ppg.Channels.Count > 2) { this.Size = sizeFourChannel; }
                    else { this.Size = sizeOneTwoChannel; }
                    
                    for (int i = 0; i < ppg.Channels.Count; i++)
                    {
                        PatternProChannelControls ppgChControls = new PatternProChannelControls();
                        ppgChControls.PatternProChannel = ppg.Channels[i];
                        this.flowLayoutPanelPPGChannels.Controls.Add(ppgChControls);
                    }

                    nudBitRate.Maximum = (decimal)(ppg.MaxBitRate / 1e9f);

                    cmbxVisaRsrcAddr.Enabled = false;
                    cmdRefresh.Enabled = false;
                    pnlGeneralControls.Enabled = true;
                    flowLayoutPanelPPGChannels.Enabled = true;

                    statusStripConnectResource.Text = ppg.ID.ToString();
                    statusStripConnectionStatus.Text = "Connected";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to connect to {visaRsrcAddr}.\r\n\r\n{ex.Message}",
                        "Error: Unable to Connect",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                cmdConnectDisconnect.Text = "Disconnect";
            }
            else // Disconnect
            {
                if (ppg != null) { ppg.Dispose(); }
                ppg = null;
                cmdConnectDisconnect.Text = "Connect";

                cmbxVisaRsrcAddr.Enabled = true;
                cmdRefresh.Enabled = true;
                pnlGeneralControls.Enabled = false;
                flowLayoutPanelPPGChannels.Enabled = false;

                statusStripConnectResource.Text = "Resource";
                statusStripConnectionStatus.Text = "Not Connected";
            }
        }

        private void Tek_PPG_Control_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ppg != null) { ppg.Dispose(); }
            ppg = null;
        }

        private void cmdAllOff_Click(object sender, EventArgs e)
        {
            foreach (PatternProChannelControls chanCtrl in this.flowLayoutPanelPPGChannels.Controls)
            {
                chanCtrl.OutputEnabled = false;
                //ppgChan.OutputEnabled = false;
            }
        }

        private void nudBitRate_ValueChanged(object sender, EventArgs e)
        {
            ppg.Frequency = (float)nudBitRate.Value * 1e9f;

            // The PPG takes some time to change bit-rate so put up busy cursor and put thread
            // to sleep so user cannot send more commands to the PPG.
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            Thread.Sleep(6000);
            this.Cursor = Cursors.Default;

            //nudBitRate.Value = (decimal)ppg.Frequency;
        }

        
    }
}
