namespace Tek_PatternPro_Generator
{
    partial class PatternProChannelControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternProChannelControls));
            this.rdbtnPattPRBS = new System.Windows.Forms.RadioButton();
            this.rdbtnPattData = new System.Windows.Forms.RadioButton();
            this.cmbxPRBSPat = new System.Windows.Forms.ComboBox();
            this.lblPattLen = new System.Windows.Forms.Label();
            this.lblPattLenVal = new System.Windows.Forms.Label();
            this.nudBitShiftBits = new System.Windows.Forms.NumericUpDown();
            this.cmdBitShift = new System.Windows.Forms.Button();
            this.cmdInjectError = new System.Windows.Forms.Button();
            this.nudAmpPos = new System.Windows.Forms.NumericUpDown();
            this.lblAmplitude = new System.Windows.Forms.Label();
            this.lblOffset = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudTerminationNeg = new System.Windows.Forms.NumericUpDown();
            this.cbxLinkVoltage = new System.Windows.Forms.CheckBox();
            this.nudOffsetNeg = new System.Windows.Forms.NumericUpDown();
            this.lblAmplitudeUnits = new System.Windows.Forms.Label();
            this.nudTerminationPos = new System.Windows.Forms.NumericUpDown();
            this.lblTermination = new System.Windows.Forms.Label();
            this.nudOffsetPos = new System.Windows.Forms.NumericUpDown();
            this.lblPositive = new System.Windows.Forms.Label();
            this.lblNegative = new System.Windows.Forms.Label();
            this.nudAmpNeg = new System.Windows.Forms.NumericUpDown();
            this.lblOffsetUnits = new System.Windows.Forms.Label();
            this.lblTerminationUnits = new System.Windows.Forms.Label();
            this.lblBitShift = new System.Windows.Forms.Label();
            this.cmdOutputEnableDisable = new System.Windows.Forms.Button();
            this.imgListOutput = new System.Windows.Forms.ImageList(this.components);
            this.grpBxPattern = new System.Windows.Forms.GroupBox();
            this.grpBxVoltage = new System.Windows.Forms.GroupBox();
            this.grpBxErrorGen = new System.Windows.Forms.GroupBox();
            this.lblOutputEnable = new System.Windows.Forms.Label();
            this.pnlChColor = new System.Windows.Forms.Panel();
            this.lblChLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBitShiftBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmpPos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminationNeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetNeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminationPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmpNeg)).BeginInit();
            this.grpBxPattern.SuspendLayout();
            this.grpBxVoltage.SuspendLayout();
            this.grpBxErrorGen.SuspendLayout();
            this.pnlChColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtnPattPRBS
            // 
            this.rdbtnPattPRBS.AutoSize = true;
            this.rdbtnPattPRBS.Location = new System.Drawing.Point(10, 19);
            this.rdbtnPattPRBS.Name = "rdbtnPattPRBS";
            this.rdbtnPattPRBS.Size = new System.Drawing.Size(54, 17);
            this.rdbtnPattPRBS.TabIndex = 0;
            this.rdbtnPattPRBS.TabStop = true;
            this.rdbtnPattPRBS.Text = "PRBS";
            this.rdbtnPattPRBS.UseVisualStyleBackColor = true;
            // 
            // rdbtnPattData
            // 
            this.rdbtnPattData.AutoSize = true;
            this.rdbtnPattData.Enabled = false;
            this.rdbtnPattData.Location = new System.Drawing.Point(85, 19);
            this.rdbtnPattData.Name = "rdbtnPattData";
            this.rdbtnPattData.Size = new System.Drawing.Size(48, 17);
            this.rdbtnPattData.TabIndex = 1;
            this.rdbtnPattData.TabStop = true;
            this.rdbtnPattData.Text = "Data";
            this.rdbtnPattData.UseVisualStyleBackColor = true;
            // 
            // cmbxPRBSPat
            // 
            this.cmbxPRBSPat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPRBSPat.FormattingEnabled = true;
            this.cmbxPRBSPat.Location = new System.Drawing.Point(10, 51);
            this.cmbxPRBSPat.Name = "cmbxPRBSPat";
            this.cmbxPRBSPat.Size = new System.Drawing.Size(121, 21);
            this.cmbxPRBSPat.TabIndex = 3;
            this.cmbxPRBSPat.SelectedIndexChanged += new System.EventHandler(this.cmbxPRBSPat_SelectedIndexChanged);
            // 
            // lblPattLen
            // 
            this.lblPattLen.AutoSize = true;
            this.lblPattLen.Location = new System.Drawing.Point(8, 84);
            this.lblPattLen.Name = "lblPattLen";
            this.lblPattLen.Size = new System.Drawing.Size(83, 13);
            this.lblPattLen.TabIndex = 4;
            this.lblPattLen.Text = "Pattern Length: ";
            // 
            // lblPattLenVal
            // 
            this.lblPattLenVal.AutoSize = true;
            this.lblPattLenVal.Location = new System.Drawing.Point(97, 84);
            this.lblPattLenVal.Name = "lblPattLenVal";
            this.lblPattLenVal.Size = new System.Drawing.Size(13, 13);
            this.lblPattLenVal.TabIndex = 5;
            this.lblPattLenVal.Text = "7";
            // 
            // nudBitShiftBits
            // 
            this.nudBitShiftBits.Location = new System.Drawing.Point(53, 21);
            this.nudBitShiftBits.Name = "nudBitShiftBits";
            this.nudBitShiftBits.Size = new System.Drawing.Size(53, 20);
            this.nudBitShiftBits.TabIndex = 6;
            this.nudBitShiftBits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmdBitShift
            // 
            this.cmdBitShift.Location = new System.Drawing.Point(115, 18);
            this.cmdBitShift.Name = "cmdBitShift";
            this.cmdBitShift.Size = new System.Drawing.Size(56, 23);
            this.cmdBitShift.TabIndex = 8;
            this.cmdBitShift.Text = "Shift";
            this.cmdBitShift.UseVisualStyleBackColor = true;
            this.cmdBitShift.Click += new System.EventHandler(this.cmdBitShift_Click);
            // 
            // cmdInjectError
            // 
            this.cmdInjectError.Location = new System.Drawing.Point(187, 18);
            this.cmdInjectError.Name = "cmdInjectError";
            this.cmdInjectError.Size = new System.Drawing.Size(75, 23);
            this.cmdInjectError.TabIndex = 9;
            this.cmdInjectError.Text = "Inject Error";
            this.cmdInjectError.UseVisualStyleBackColor = true;
            this.cmdInjectError.Click += new System.EventHandler(this.cmdInjectError_Click);
            // 
            // nudAmpPos
            // 
            this.nudAmpPos.DecimalPlaces = 3;
            this.nudAmpPos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudAmpPos.Location = new System.Drawing.Point(78, 27);
            this.nudAmpPos.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmpPos.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.nudAmpPos.Name = "nudAmpPos";
            this.nudAmpPos.Size = new System.Drawing.Size(66, 20);
            this.nudAmpPos.TabIndex = 10;
            this.nudAmpPos.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudAmpPos.ValueChanged += new System.EventHandler(this.nudAmpPos_ValueChanged);
            // 
            // lblAmplitude
            // 
            this.lblAmplitude.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmplitude.AutoSize = true;
            this.lblAmplitude.Location = new System.Drawing.Point(16, 30);
            this.lblAmplitude.Name = "lblAmplitude";
            this.lblAmplitude.Size = new System.Drawing.Size(56, 13);
            this.lblAmplitude.TabIndex = 11;
            this.lblAmplitude.Text = "Amplitude:";
            // 
            // lblOffset
            // 
            this.lblOffset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(34, 56);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(38, 13);
            this.lblOffset.TabIndex = 12;
            this.lblOffset.Text = "Offset:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.nudTerminationNeg, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxLinkVoltage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudOffsetNeg, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAmplitudeUnits, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudTerminationPos, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTermination, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblOffset, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAmplitude, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudOffsetPos, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudAmpPos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPositive, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNegative, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudAmpNeg, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOffsetUnits, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTerminationUnits, 4, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 104);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // nudTerminationNeg
            // 
            this.nudTerminationNeg.DecimalPlaces = 3;
            this.nudTerminationNeg.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudTerminationNeg.Location = new System.Drawing.Point(170, 79);
            this.nudTerminationNeg.Maximum = new decimal(new int[] {
            33,
            0,
            0,
            65536});
            this.nudTerminationNeg.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.nudTerminationNeg.Name = "nudTerminationNeg";
            this.nudTerminationNeg.Size = new System.Drawing.Size(66, 20);
            this.nudTerminationNeg.TabIndex = 15;
            this.nudTerminationNeg.ValueChanged += new System.EventHandler(this.nudTerminationNeg_ValueChanged);
            // 
            // cbxLinkVoltage
            // 
            this.cbxLinkVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLinkVoltage.AutoSize = true;
            this.cbxLinkVoltage.Location = new System.Drawing.Point(26, 4);
            this.cbxLinkVoltage.Name = "cbxLinkVoltage";
            this.cbxLinkVoltage.Size = new System.Drawing.Size(46, 17);
            this.cbxLinkVoltage.TabIndex = 16;
            this.cbxLinkVoltage.Text = "Link";
            this.cbxLinkVoltage.UseVisualStyleBackColor = true;
            this.cbxLinkVoltage.CheckedChanged += new System.EventHandler(this.cbxLinkVoltage_CheckedChanged);
            // 
            // nudOffsetNeg
            // 
            this.nudOffsetNeg.DecimalPlaces = 3;
            this.nudOffsetNeg.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudOffsetNeg.Location = new System.Drawing.Point(170, 53);
            this.nudOffsetNeg.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudOffsetNeg.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.nudOffsetNeg.Name = "nudOffsetNeg";
            this.nudOffsetNeg.Size = new System.Drawing.Size(66, 20);
            this.nudOffsetNeg.TabIndex = 15;
            this.nudOffsetNeg.ValueChanged += new System.EventHandler(this.nudOffsetNeg_ValueChanged);
            // 
            // lblAmplitudeUnits
            // 
            this.lblAmplitudeUnits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmplitudeUnits.AutoSize = true;
            this.lblAmplitudeUnits.Location = new System.Drawing.Point(243, 30);
            this.lblAmplitudeUnits.Name = "lblAmplitudeUnits";
            this.lblAmplitudeUnits.Size = new System.Drawing.Size(14, 13);
            this.lblAmplitudeUnits.TabIndex = 15;
            this.lblAmplitudeUnits.Text = "V";
            // 
            // nudTerminationPos
            // 
            this.nudTerminationPos.DecimalPlaces = 3;
            this.nudTerminationPos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudTerminationPos.Location = new System.Drawing.Point(78, 79);
            this.nudTerminationPos.Maximum = new decimal(new int[] {
            33,
            0,
            0,
            65536});
            this.nudTerminationPos.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.nudTerminationPos.Name = "nudTerminationPos";
            this.nudTerminationPos.Size = new System.Drawing.Size(66, 20);
            this.nudTerminationPos.TabIndex = 14;
            this.nudTerminationPos.ValueChanged += new System.EventHandler(this.nudTerminationPos_ValueChanged);
            // 
            // lblTermination
            // 
            this.lblTermination.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTermination.AutoSize = true;
            this.lblTermination.Location = new System.Drawing.Point(7, 83);
            this.lblTermination.Name = "lblTermination";
            this.lblTermination.Size = new System.Drawing.Size(65, 13);
            this.lblTermination.TabIndex = 14;
            this.lblTermination.Text = "Termination:";
            // 
            // nudOffsetPos
            // 
            this.nudOffsetPos.DecimalPlaces = 3;
            this.nudOffsetPos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudOffsetPos.Location = new System.Drawing.Point(78, 53);
            this.nudOffsetPos.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudOffsetPos.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.nudOffsetPos.Name = "nudOffsetPos";
            this.nudOffsetPos.Size = new System.Drawing.Size(66, 20);
            this.nudOffsetPos.TabIndex = 14;
            this.nudOffsetPos.ValueChanged += new System.EventHandler(this.nudOffsetPos_ValueChanged);
            // 
            // lblPositive
            // 
            this.lblPositive.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPositive.AutoSize = true;
            this.lblPositive.Location = new System.Drawing.Point(89, 11);
            this.lblPositive.Name = "lblPositive";
            this.lblPositive.Size = new System.Drawing.Size(44, 13);
            this.lblPositive.TabIndex = 15;
            this.lblPositive.Text = "Positive";
            // 
            // lblNegative
            // 
            this.lblNegative.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNegative.AutoSize = true;
            this.lblNegative.Location = new System.Drawing.Point(178, 11);
            this.lblNegative.Name = "lblNegative";
            this.lblNegative.Size = new System.Drawing.Size(50, 13);
            this.lblNegative.TabIndex = 16;
            this.lblNegative.Text = "Negative";
            // 
            // nudAmpNeg
            // 
            this.nudAmpNeg.DecimalPlaces = 3;
            this.nudAmpNeg.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudAmpNeg.Location = new System.Drawing.Point(170, 27);
            this.nudAmpNeg.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmpNeg.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.nudAmpNeg.Name = "nudAmpNeg";
            this.nudAmpNeg.Size = new System.Drawing.Size(66, 20);
            this.nudAmpNeg.TabIndex = 14;
            this.nudAmpNeg.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudAmpNeg.ValueChanged += new System.EventHandler(this.nudAmpNeg_ValueChanged);
            // 
            // lblOffsetUnits
            // 
            this.lblOffsetUnits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOffsetUnits.AutoSize = true;
            this.lblOffsetUnits.Location = new System.Drawing.Point(243, 56);
            this.lblOffsetUnits.Name = "lblOffsetUnits";
            this.lblOffsetUnits.Size = new System.Drawing.Size(14, 13);
            this.lblOffsetUnits.TabIndex = 18;
            this.lblOffsetUnits.Text = "V";
            // 
            // lblTerminationUnits
            // 
            this.lblTerminationUnits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTerminationUnits.AutoSize = true;
            this.lblTerminationUnits.Location = new System.Drawing.Point(243, 83);
            this.lblTerminationUnits.Name = "lblTerminationUnits";
            this.lblTerminationUnits.Size = new System.Drawing.Size(14, 13);
            this.lblTerminationUnits.TabIndex = 19;
            this.lblTerminationUnits.Text = "V";
            // 
            // lblBitShift
            // 
            this.lblBitShift.AutoSize = true;
            this.lblBitShift.Location = new System.Drawing.Point(6, 23);
            this.lblBitShift.Name = "lblBitShift";
            this.lblBitShift.Size = new System.Drawing.Size(46, 13);
            this.lblBitShift.TabIndex = 14;
            this.lblBitShift.Text = "Bit Shift:";
            // 
            // cmdOutputEnableDisable
            // 
            this.cmdOutputEnableDisable.BackColor = System.Drawing.SystemColors.Window;
            this.cmdOutputEnableDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOutputEnableDisable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOutputEnableDisable.ImageIndex = 0;
            this.cmdOutputEnableDisable.ImageList = this.imgListOutput;
            this.cmdOutputEnableDisable.Location = new System.Drawing.Point(228, 36);
            this.cmdOutputEnableDisable.Name = "cmdOutputEnableDisable";
            this.cmdOutputEnableDisable.Size = new System.Drawing.Size(42, 42);
            this.cmdOutputEnableDisable.TabIndex = 15;
            this.cmdOutputEnableDisable.UseVisualStyleBackColor = false;
            this.cmdOutputEnableDisable.Click += new System.EventHandler(this.cmdOutputEnableDisable_Click);
            // 
            // imgListOutput
            // 
            this.imgListOutput.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListOutput.ImageStream")));
            this.imgListOutput.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListOutput.Images.SetKeyName(0, "power_button_off_icon_32px.png");
            this.imgListOutput.Images.SetKeyName(1, "power_button_on_icon_32px.png");
            // 
            // grpBxPattern
            // 
            this.grpBxPattern.Controls.Add(this.rdbtnPattPRBS);
            this.grpBxPattern.Controls.Add(this.rdbtnPattData);
            this.grpBxPattern.Controls.Add(this.cmbxPRBSPat);
            this.grpBxPattern.Controls.Add(this.lblPattLen);
            this.grpBxPattern.Controls.Add(this.lblPattLenVal);
            this.grpBxPattern.Location = new System.Drawing.Point(3, 3);
            this.grpBxPattern.Name = "grpBxPattern";
            this.grpBxPattern.Size = new System.Drawing.Size(144, 109);
            this.grpBxPattern.TabIndex = 17;
            this.grpBxPattern.TabStop = false;
            this.grpBxPattern.Text = "Pattern";
            // 
            // grpBxVoltage
            // 
            this.grpBxVoltage.Controls.Add(this.tableLayoutPanel1);
            this.grpBxVoltage.Location = new System.Drawing.Point(3, 118);
            this.grpBxVoltage.Name = "grpBxVoltage";
            this.grpBxVoltage.Size = new System.Drawing.Size(272, 131);
            this.grpBxVoltage.TabIndex = 18;
            this.grpBxVoltage.TabStop = false;
            this.grpBxVoltage.Text = "Voltage";
            // 
            // grpBxErrorGen
            // 
            this.grpBxErrorGen.Controls.Add(this.lblBitShift);
            this.grpBxErrorGen.Controls.Add(this.nudBitShiftBits);
            this.grpBxErrorGen.Controls.Add(this.cmdBitShift);
            this.grpBxErrorGen.Controls.Add(this.cmdInjectError);
            this.grpBxErrorGen.Location = new System.Drawing.Point(3, 255);
            this.grpBxErrorGen.Name = "grpBxErrorGen";
            this.grpBxErrorGen.Size = new System.Drawing.Size(272, 49);
            this.grpBxErrorGen.TabIndex = 19;
            this.grpBxErrorGen.TabStop = false;
            this.grpBxErrorGen.Text = "Error Generation";
            // 
            // lblOutputEnable
            // 
            this.lblOutputEnable.AutoSize = true;
            this.lblOutputEnable.Location = new System.Drawing.Point(180, 51);
            this.lblOutputEnable.Name = "lblOutputEnable";
            this.lblOutputEnable.Size = new System.Drawing.Size(42, 13);
            this.lblOutputEnable.TabIndex = 20;
            this.lblOutputEnable.Text = "Output:";
            // 
            // pnlChColor
            // 
            this.pnlChColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(5)))));
            this.pnlChColor.Controls.Add(this.lblChLabel);
            this.pnlChColor.Location = new System.Drawing.Point(151, 0);
            this.pnlChColor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChColor.Name = "pnlChColor";
            this.pnlChColor.Size = new System.Drawing.Size(130, 30);
            this.pnlChColor.TabIndex = 21;
            // 
            // lblChLabel
            // 
            this.lblChLabel.AutoSize = true;
            this.lblChLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChLabel.Location = new System.Drawing.Point(7, 3);
            this.lblChLabel.Name = "lblChLabel";
            this.lblChLabel.Size = new System.Drawing.Size(111, 24);
            this.lblChLabel.TabIndex = 0;
            this.lblChLabel.Text = "Channel 1";
            // 
            // PatternProChannelControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlChColor);
            this.Controls.Add(this.lblOutputEnable);
            this.Controls.Add(this.grpBxErrorGen);
            this.Controls.Add(this.grpBxVoltage);
            this.Controls.Add(this.grpBxPattern);
            this.Controls.Add(this.cmdOutputEnableDisable);
            this.Name = "PatternProChannelControls";
            this.Size = new System.Drawing.Size(281, 310);
            this.Load += new System.EventHandler(this.PPG_Channel_Controls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBitShiftBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmpPos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminationNeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetNeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminationPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmpNeg)).EndInit();
            this.grpBxPattern.ResumeLayout(false);
            this.grpBxPattern.PerformLayout();
            this.grpBxVoltage.ResumeLayout(false);
            this.grpBxErrorGen.ResumeLayout(false);
            this.grpBxErrorGen.PerformLayout();
            this.pnlChColor.ResumeLayout(false);
            this.pnlChColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnPattPRBS;
        private System.Windows.Forms.RadioButton rdbtnPattData;
        private System.Windows.Forms.ComboBox cmbxPRBSPat;
        private System.Windows.Forms.Label lblPattLen;
        private System.Windows.Forms.Label lblPattLenVal;
        private System.Windows.Forms.NumericUpDown nudBitShiftBits;
        private System.Windows.Forms.Button cmdBitShift;
        private System.Windows.Forms.Button cmdInjectError;
        private System.Windows.Forms.NumericUpDown nudAmpPos;
        private System.Windows.Forms.Label lblAmplitude;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown nudTerminationPos;
        private System.Windows.Forms.Label lblTermination;
        private System.Windows.Forms.NumericUpDown nudOffsetPos;
        private System.Windows.Forms.NumericUpDown nudAmpNeg;
        private System.Windows.Forms.Label lblPositive;
        private System.Windows.Forms.Label lblNegative;
        private System.Windows.Forms.NumericUpDown nudTerminationNeg;
        private System.Windows.Forms.NumericUpDown nudOffsetNeg;
        private System.Windows.Forms.Label lblAmplitudeUnits;
        private System.Windows.Forms.Label lblOffsetUnits;
        private System.Windows.Forms.Label lblTerminationUnits;
        private System.Windows.Forms.Label lblBitShift;
        private System.Windows.Forms.Button cmdOutputEnableDisable;
        private System.Windows.Forms.ImageList imgListOutput;
        private System.Windows.Forms.CheckBox cbxLinkVoltage;
        private System.Windows.Forms.GroupBox grpBxPattern;
        private System.Windows.Forms.GroupBox grpBxVoltage;
        private System.Windows.Forms.GroupBox grpBxErrorGen;
        private System.Windows.Forms.Label lblOutputEnable;
        private System.Windows.Forms.Panel pnlChColor;
        private System.Windows.Forms.Label lblChLabel;
    }
}
