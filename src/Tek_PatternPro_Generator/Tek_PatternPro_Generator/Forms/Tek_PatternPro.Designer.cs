namespace Tek_PatternPro_Generator
{
    partial class Tek_PatternPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tek_PatternPro));
            this.flowLayoutPanelPPGChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.ppG_Channel_Controls1 = new Tek_PatternPro_Generator.PatternProChannelControls();
            this.cmbxVisaRsrcAddr = new System.Windows.Forms.ComboBox();
            this.lblVisaRsrcAddr = new System.Windows.Forms.Label();
            this.cmdConnectDisconnect = new System.Windows.Forms.Button();
            this.cmdAllOff = new System.Windows.Forms.Button();
            this.lblGbps = new System.Windows.Forms.Label();
            this.nudBitRate = new System.Windows.Forms.NumericUpDown();
            this.lblBitRate = new System.Windows.Forms.Label();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.pnlGeneralControls = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripConnectResource = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanelPPGChannels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBitRate)).BeginInit();
            this.pnlGeneralControls.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPPGChannels
            // 
            this.flowLayoutPanelPPGChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPPGChannels.Controls.Add(this.ppG_Channel_Controls1);
            this.flowLayoutPanelPPGChannels.Enabled = false;
            this.flowLayoutPanelPPGChannels.Location = new System.Drawing.Point(12, 55);
            this.flowLayoutPanelPPGChannels.Name = "flowLayoutPanelPPGChannels";
            this.flowLayoutPanelPPGChannels.Size = new System.Drawing.Size(574, 315);
            this.flowLayoutPanelPPGChannels.TabIndex = 0;
            // 
            // ppG_Channel_Controls1
            // 
            this.ppG_Channel_Controls1.Location = new System.Drawing.Point(3, 3);
            this.ppG_Channel_Controls1.Name = "ppG_Channel_Controls1";
            this.ppG_Channel_Controls1.OutputEnabled = false;
            this.ppG_Channel_Controls1.PatternProChannel = null;
            this.ppG_Channel_Controls1.Size = new System.Drawing.Size(281, 310);
            this.ppG_Channel_Controls1.TabIndex = 0;
            // 
            // cmbxVisaRsrcAddr
            // 
            this.cmbxVisaRsrcAddr.FormattingEnabled = true;
            this.cmbxVisaRsrcAddr.Location = new System.Drawing.Point(12, 26);
            this.cmbxVisaRsrcAddr.Name = "cmbxVisaRsrcAddr";
            this.cmbxVisaRsrcAddr.Size = new System.Drawing.Size(282, 21);
            this.cmbxVisaRsrcAddr.TabIndex = 1;
            // 
            // lblVisaRsrcAddr
            // 
            this.lblVisaRsrcAddr.AutoSize = true;
            this.lblVisaRsrcAddr.Location = new System.Drawing.Point(13, 7);
            this.lblVisaRsrcAddr.Name = "lblVisaRsrcAddr";
            this.lblVisaRsrcAddr.Size = new System.Drawing.Size(124, 13);
            this.lblVisaRsrcAddr.TabIndex = 2;
            this.lblVisaRsrcAddr.Text = "VISA Resource Address:";
            // 
            // cmdConnectDisconnect
            // 
            this.cmdConnectDisconnect.Location = new System.Drawing.Point(300, 26);
            this.cmdConnectDisconnect.Name = "cmdConnectDisconnect";
            this.cmdConnectDisconnect.Size = new System.Drawing.Size(75, 23);
            this.cmdConnectDisconnect.TabIndex = 3;
            this.cmdConnectDisconnect.Text = "Connect";
            this.cmdConnectDisconnect.UseVisualStyleBackColor = true;
            this.cmdConnectDisconnect.Click += new System.EventHandler(this.cmdConnectDisconnect_Click);
            // 
            // cmdAllOff
            // 
            this.cmdAllOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAllOff.Location = new System.Drawing.Point(467, 2);
            this.cmdAllOff.Name = "cmdAllOff";
            this.cmdAllOff.Size = new System.Drawing.Size(103, 34);
            this.cmdAllOff.TabIndex = 4;
            this.cmdAllOff.Text = "All Outputs Off";
            this.cmdAllOff.UseVisualStyleBackColor = true;
            this.cmdAllOff.Click += new System.EventHandler(this.cmdAllOff_Click);
            // 
            // lblGbps
            // 
            this.lblGbps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGbps.AutoSize = true;
            this.lblGbps.Location = new System.Drawing.Point(148, 14);
            this.lblGbps.Name = "lblGbps";
            this.lblGbps.Size = new System.Drawing.Size(32, 13);
            this.lblGbps.TabIndex = 27;
            this.lblGbps.Text = "Gbps";
            // 
            // nudBitRate
            // 
            this.nudBitRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudBitRate.DecimalPlaces = 6;
            this.nudBitRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBitRate.Location = new System.Drawing.Point(70, 10);
            this.nudBitRate.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudBitRate.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.nudBitRate.Name = "nudBitRate";
            this.nudBitRate.Size = new System.Drawing.Size(73, 20);
            this.nudBitRate.TabIndex = 26;
            this.nudBitRate.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudBitRate.ValueChanged += new System.EventHandler(this.nudBitRate_ValueChanged);
            // 
            // lblBitRate
            // 
            this.lblBitRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBitRate.AutoSize = true;
            this.lblBitRate.Location = new System.Drawing.Point(19, 14);
            this.lblBitRate.Name = "lblBitRate";
            this.lblBitRate.Size = new System.Drawing.Size(48, 13);
            this.lblBitRate.TabIndex = 25;
            this.lblBitRate.Text = "Bit Rate:";
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Location = new System.Drawing.Point(381, 26);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(75, 23);
            this.cmdRefresh.TabIndex = 28;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // pnlGeneralControls
            // 
            this.pnlGeneralControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGeneralControls.Controls.Add(this.lblBitRate);
            this.pnlGeneralControls.Controls.Add(this.nudBitRate);
            this.pnlGeneralControls.Controls.Add(this.cmdAllOff);
            this.pnlGeneralControls.Controls.Add(this.lblGbps);
            this.pnlGeneralControls.Enabled = false;
            this.pnlGeneralControls.Location = new System.Drawing.Point(12, 367);
            this.pnlGeneralControls.Name = "pnlGeneralControls";
            this.pnlGeneralControls.Size = new System.Drawing.Size(574, 39);
            this.pnlGeneralControls.TabIndex = 29;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripConnectResource,
            this.toolStripStatusLabel1,
            this.statusStripConnectionStatus,
            this.statusStripVersion});
            this.statusStrip.Location = new System.Drawing.Point(0, 409);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(594, 22);
            this.statusStrip.TabIndex = 30;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripConnectResource
            // 
            this.statusStripConnectResource.Name = "statusStripConnectResource";
            this.statusStripConnectResource.Size = new System.Drawing.Size(55, 17);
            this.statusStripConnectResource.Text = "Resource";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // statusStripConnectionStatus
            // 
            this.statusStripConnectionStatus.Name = "statusStripConnectionStatus";
            this.statusStripConnectionStatus.Size = new System.Drawing.Size(88, 17);
            this.statusStripConnectionStatus.Text = "Not Connected";
            // 
            // statusStripVersion
            // 
            this.statusStripVersion.Name = "statusStripVersion";
            this.statusStripVersion.Size = new System.Drawing.Size(50, 17);
            this.statusStripVersion.Text = "xX.X.X.X";
            // 
            // Tek_PatternPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 431);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlGeneralControls);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdConnectDisconnect);
            this.Controls.Add(this.lblVisaRsrcAddr);
            this.Controls.Add(this.cmbxVisaRsrcAddr);
            this.Controls.Add(this.flowLayoutPanelPPGChannels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tek_PatternPro";
            this.Text = "Tek PatternPro Pattern Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tek_PPG_Control_FormClosing);
            this.Load += new System.EventHandler(this.Tek_PPG_Control_Load);
            this.flowLayoutPanelPPGChannels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBitRate)).EndInit();
            this.pnlGeneralControls.ResumeLayout(false);
            this.pnlGeneralControls.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPPGChannels;
        private System.Windows.Forms.ComboBox cmbxVisaRsrcAddr;
        private System.Windows.Forms.Label lblVisaRsrcAddr;
        private System.Windows.Forms.Button cmdConnectDisconnect;
        private System.Windows.Forms.Button cmdAllOff;
        private PatternProChannelControls ppG_Channel_Controls1;
        private System.Windows.Forms.Label lblGbps;
        private System.Windows.Forms.NumericUpDown nudBitRate;
        private System.Windows.Forms.Label lblBitRate;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Panel pnlGeneralControls;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripConnectResource;
        private System.Windows.Forms.ToolStripStatusLabel statusStripConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripVersion;
    }
}

