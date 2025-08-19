namespace Janus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.previousDayButton = new System.Windows.Forms.Button();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.dayHeaderLabel = new System.Windows.Forms.Label();
            this.MondayHours = new System.Windows.Forms.Label();
            this.TuesdayHours = new System.Windows.Forms.Label();
            this.WednesdayHours = new System.Windows.Forms.Label();
            this.ThursdayHours = new System.Windows.Forms.Label();
            this.FridayHours = new System.Windows.Forms.Label();
            this.SaturdayHours = new System.Windows.Forms.Label();
            this.SundayHours = new System.Windows.Forms.Label();
            this.SundayDelta = new System.Windows.Forms.Label();
            this.SaturdayDelta = new System.Windows.Forms.Label();
            this.FridayDelta = new System.Windows.Forms.Label();
            this.ThursdayDelta = new System.Windows.Forms.Label();
            this.WednesdayDelta = new System.Windows.Forms.Label();
            this.TuesdayDelta = new System.Windows.Forms.Label();
            this.MondayDelta = new System.Windows.Forms.Label();
            this.SundayName = new System.Windows.Forms.Label();
            this.SaturdayName = new System.Windows.Forms.Label();
            this.FridayName = new System.Windows.Forms.Label();
            this.ThursdayName = new System.Windows.Forms.Label();
            this.WednesdayName = new System.Windows.Forms.Label();
            this.TuesdayName = new System.Windows.Forms.Label();
            this.MondayName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.setStartToNow = new System.Windows.Forms.Button();
            this.setEndToNow = new System.Windows.Forms.Button();
            this.breakMinutesInput = new System.Windows.Forms.NumericUpDown();
            this.thirtyMinuteBreak = new System.Windows.Forms.Button();
            this.fifteenMinuteBreak = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.autoEndHours = new System.Windows.Forms.Button();
            this.zeroBreak = new System.Windows.Forms.Button();
            this.kmDriven = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.extraHoursLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SettingsCategory = new System.Windows.Forms.ToolStripSplitButton();
            this.openOpslaglocatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMonthPDF = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakMinutesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmDriven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // previousDayButton
            // 
            this.previousDayButton.Location = new System.Drawing.Point(12, 27);
            this.previousDayButton.Name = "previousDayButton";
            this.previousDayButton.Size = new System.Drawing.Size(30, 23);
            this.previousDayButton.TabIndex = 0;
            this.previousDayButton.Text = "←";
            this.previousDayButton.UseVisualStyleBackColor = true;
            this.previousDayButton.Click += new System.EventHandler(this.previousDayButton_Click);
            // 
            // nextDayButton
            // 
            this.nextDayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextDayButton.Location = new System.Drawing.Point(396, 27);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(30, 23);
            this.nextDayButton.TabIndex = 1;
            this.nextDayButton.Text = "→";
            this.nextDayButton.UseVisualStyleBackColor = true;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // dayHeaderLabel
            // 
            this.dayHeaderLabel.AutoSize = true;
            this.dayHeaderLabel.Location = new System.Drawing.Point(48, 32);
            this.dayHeaderLabel.Name = "dayHeaderLabel";
            this.dayHeaderLabel.Size = new System.Drawing.Size(35, 13);
            this.dayHeaderLabel.TabIndex = 2;
            this.dayHeaderLabel.Text = "label1";
            // 
            // MondayHours
            // 
            this.MondayHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MondayHours.Location = new System.Drawing.Point(12, 215);
            this.MondayHours.Name = "MondayHours";
            this.MondayHours.Size = new System.Drawing.Size(35, 16);
            this.MondayHours.TabIndex = 3;
            this.MondayHours.Text = "08:00";
            this.MondayHours.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TuesdayHours
            // 
            this.TuesdayHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TuesdayHours.Location = new System.Drawing.Point(53, 215);
            this.TuesdayHours.Name = "TuesdayHours";
            this.TuesdayHours.Size = new System.Drawing.Size(35, 16);
            this.TuesdayHours.TabIndex = 4;
            this.TuesdayHours.Text = "08:00";
            this.TuesdayHours.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WednesdayHours
            // 
            this.WednesdayHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WednesdayHours.Location = new System.Drawing.Point(94, 215);
            this.WednesdayHours.Name = "WednesdayHours";
            this.WednesdayHours.Size = new System.Drawing.Size(35, 16);
            this.WednesdayHours.TabIndex = 5;
            this.WednesdayHours.Text = "08:00";
            this.WednesdayHours.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ThursdayHours
            // 
            this.ThursdayHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThursdayHours.Location = new System.Drawing.Point(135, 215);
            this.ThursdayHours.Name = "ThursdayHours";
            this.ThursdayHours.Size = new System.Drawing.Size(35, 16);
            this.ThursdayHours.TabIndex = 6;
            this.ThursdayHours.Text = "08:00";
            this.ThursdayHours.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FridayHours
            // 
            this.FridayHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FridayHours.Location = new System.Drawing.Point(176, 215);
            this.FridayHours.Name = "FridayHours";
            this.FridayHours.Size = new System.Drawing.Size(35, 16);
            this.FridayHours.TabIndex = 7;
            this.FridayHours.Text = "08:00";
            this.FridayHours.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SaturdayHours
            // 
            this.SaturdayHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaturdayHours.Location = new System.Drawing.Point(217, 215);
            this.SaturdayHours.Name = "SaturdayHours";
            this.SaturdayHours.Size = new System.Drawing.Size(35, 16);
            this.SaturdayHours.TabIndex = 8;
            this.SaturdayHours.Text = "08:00";
            this.SaturdayHours.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SundayHours
            // 
            this.SundayHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SundayHours.Location = new System.Drawing.Point(258, 215);
            this.SundayHours.Name = "SundayHours";
            this.SundayHours.Size = new System.Drawing.Size(35, 16);
            this.SundayHours.TabIndex = 9;
            this.SundayHours.Text = "08:00";
            this.SundayHours.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SundayDelta
            // 
            this.SundayDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SundayDelta.Location = new System.Drawing.Point(258, 231);
            this.SundayDelta.Name = "SundayDelta";
            this.SundayDelta.Size = new System.Drawing.Size(35, 16);
            this.SundayDelta.TabIndex = 16;
            this.SundayDelta.Text = "+5";
            this.SundayDelta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SaturdayDelta
            // 
            this.SaturdayDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaturdayDelta.Location = new System.Drawing.Point(217, 231);
            this.SaturdayDelta.Name = "SaturdayDelta";
            this.SaturdayDelta.Size = new System.Drawing.Size(35, 16);
            this.SaturdayDelta.TabIndex = 15;
            this.SaturdayDelta.Text = "+5";
            this.SaturdayDelta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FridayDelta
            // 
            this.FridayDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FridayDelta.Location = new System.Drawing.Point(176, 231);
            this.FridayDelta.Name = "FridayDelta";
            this.FridayDelta.Size = new System.Drawing.Size(35, 16);
            this.FridayDelta.TabIndex = 14;
            this.FridayDelta.Text = "+5";
            this.FridayDelta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ThursdayDelta
            // 
            this.ThursdayDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThursdayDelta.Location = new System.Drawing.Point(135, 231);
            this.ThursdayDelta.Name = "ThursdayDelta";
            this.ThursdayDelta.Size = new System.Drawing.Size(35, 16);
            this.ThursdayDelta.TabIndex = 13;
            this.ThursdayDelta.Text = "+5";
            this.ThursdayDelta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WednesdayDelta
            // 
            this.WednesdayDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WednesdayDelta.Location = new System.Drawing.Point(94, 231);
            this.WednesdayDelta.Name = "WednesdayDelta";
            this.WednesdayDelta.Size = new System.Drawing.Size(35, 16);
            this.WednesdayDelta.TabIndex = 12;
            this.WednesdayDelta.Text = "+5";
            this.WednesdayDelta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TuesdayDelta
            // 
            this.TuesdayDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TuesdayDelta.Location = new System.Drawing.Point(53, 231);
            this.TuesdayDelta.Name = "TuesdayDelta";
            this.TuesdayDelta.Size = new System.Drawing.Size(35, 16);
            this.TuesdayDelta.TabIndex = 11;
            this.TuesdayDelta.Text = "+5";
            this.TuesdayDelta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MondayDelta
            // 
            this.MondayDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MondayDelta.Location = new System.Drawing.Point(12, 231);
            this.MondayDelta.Name = "MondayDelta";
            this.MondayDelta.Size = new System.Drawing.Size(35, 16);
            this.MondayDelta.TabIndex = 10;
            this.MondayDelta.Text = "+5";
            this.MondayDelta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SundayName
            // 
            this.SundayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SundayName.Location = new System.Drawing.Point(258, 199);
            this.SundayName.Name = "SundayName";
            this.SundayName.Size = new System.Drawing.Size(35, 16);
            this.SundayName.TabIndex = 23;
            this.SundayName.Text = "Zo";
            this.SundayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SaturdayName
            // 
            this.SaturdayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaturdayName.Location = new System.Drawing.Point(217, 199);
            this.SaturdayName.Name = "SaturdayName";
            this.SaturdayName.Size = new System.Drawing.Size(35, 16);
            this.SaturdayName.TabIndex = 22;
            this.SaturdayName.Text = "Za";
            this.SaturdayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FridayName
            // 
            this.FridayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FridayName.Location = new System.Drawing.Point(176, 199);
            this.FridayName.Name = "FridayName";
            this.FridayName.Size = new System.Drawing.Size(35, 16);
            this.FridayName.TabIndex = 21;
            this.FridayName.Text = "Vr";
            this.FridayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ThursdayName
            // 
            this.ThursdayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThursdayName.Location = new System.Drawing.Point(135, 199);
            this.ThursdayName.Name = "ThursdayName";
            this.ThursdayName.Size = new System.Drawing.Size(35, 16);
            this.ThursdayName.TabIndex = 20;
            this.ThursdayName.Text = "Do";
            this.ThursdayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WednesdayName
            // 
            this.WednesdayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WednesdayName.Location = new System.Drawing.Point(94, 199);
            this.WednesdayName.Name = "WednesdayName";
            this.WednesdayName.Size = new System.Drawing.Size(35, 16);
            this.WednesdayName.TabIndex = 19;
            this.WednesdayName.Text = "Wo";
            this.WednesdayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TuesdayName
            // 
            this.TuesdayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TuesdayName.Location = new System.Drawing.Point(53, 199);
            this.TuesdayName.Name = "TuesdayName";
            this.TuesdayName.Size = new System.Drawing.Size(35, 16);
            this.TuesdayName.TabIndex = 18;
            this.TuesdayName.Text = "Di";
            this.TuesdayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MondayName
            // 
            this.MondayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MondayName.Location = new System.Drawing.Point(12, 199);
            this.MondayName.Name = "MondayName";
            this.MondayName.Size = new System.Drawing.Size(35, 16);
            this.MondayName.TabIndex = 17;
            this.MondayName.Text = "Ma";
            this.MondayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMonthPDF,
            this.SettingsCategory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(438, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Begintijd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Eindtijd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Pauze (minuten)";
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "HH:mm";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(112, 73);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(77, 20);
            this.startTimePicker.TabIndex = 28;
            this.startTimePicker.Value = new System.DateTime(2025, 8, 19, 8, 0, 0, 0);
            this.startTimePicker.ValueChanged += new System.EventHandler(this.startTimePicker_ValueChanged);
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "HH:mm";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(112, 99);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(77, 20);
            this.endTimePicker.TabIndex = 29;
            this.endTimePicker.Value = new System.DateTime(2025, 8, 19, 8, 0, 0, 0);
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // setStartToNow
            // 
            this.setStartToNow.Location = new System.Drawing.Point(195, 73);
            this.setStartToNow.Name = "setStartToNow";
            this.setStartToNow.Size = new System.Drawing.Size(31, 20);
            this.setStartToNow.TabIndex = 31;
            this.setStartToNow.Text = "Nu";
            this.setStartToNow.UseVisualStyleBackColor = true;
            this.setStartToNow.Click += new System.EventHandler(this.setStartToNow_Click);
            // 
            // setEndToNow
            // 
            this.setEndToNow.Location = new System.Drawing.Point(195, 99);
            this.setEndToNow.Name = "setEndToNow";
            this.setEndToNow.Size = new System.Drawing.Size(31, 20);
            this.setEndToNow.TabIndex = 32;
            this.setEndToNow.Text = "Nu";
            this.setEndToNow.UseVisualStyleBackColor = true;
            this.setEndToNow.Click += new System.EventHandler(this.setEndToNow_Click);
            // 
            // breakMinutesInput
            // 
            this.breakMinutesInput.Location = new System.Drawing.Point(112, 129);
            this.breakMinutesInput.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.breakMinutesInput.Name = "breakMinutesInput";
            this.breakMinutesInput.Size = new System.Drawing.Size(77, 20);
            this.breakMinutesInput.TabIndex = 33;
            this.breakMinutesInput.ValueChanged += new System.EventHandler(this.breakMinutesInput_ValueChanged);
            // 
            // thirtyMinuteBreak
            // 
            this.thirtyMinuteBreak.Location = new System.Drawing.Point(195, 129);
            this.thirtyMinuteBreak.Name = "thirtyMinuteBreak";
            this.thirtyMinuteBreak.Size = new System.Drawing.Size(31, 20);
            this.thirtyMinuteBreak.TabIndex = 34;
            this.thirtyMinuteBreak.Text = "30";
            this.thirtyMinuteBreak.UseVisualStyleBackColor = true;
            this.thirtyMinuteBreak.Click += new System.EventHandler(this.thirtyMinuteBreak_Click);
            // 
            // fifteenMinuteBreak
            // 
            this.fifteenMinuteBreak.Location = new System.Drawing.Point(232, 129);
            this.fifteenMinuteBreak.Name = "fifteenMinuteBreak";
            this.fifteenMinuteBreak.Size = new System.Drawing.Size(31, 20);
            this.fifteenMinuteBreak.TabIndex = 35;
            this.fifteenMinuteBreak.Text = "15";
            this.fifteenMinuteBreak.UseVisualStyleBackColor = true;
            this.fifteenMinuteBreak.Click += new System.EventHandler(this.fifteenMinuteBreak_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PDF Bestanden|*.pdf";
            // 
            // autoEndHours
            // 
            this.autoEndHours.Location = new System.Drawing.Point(232, 99);
            this.autoEndHours.Name = "autoEndHours";
            this.autoEndHours.Size = new System.Drawing.Size(68, 20);
            this.autoEndHours.TabIndex = 36;
            this.autoEndHours.Text = "Auto";
            this.autoEndHours.UseVisualStyleBackColor = true;
            this.autoEndHours.Click += new System.EventHandler(this.autoEndHours_Click);
            // 
            // zeroBreak
            // 
            this.zeroBreak.Location = new System.Drawing.Point(269, 129);
            this.zeroBreak.Name = "zeroBreak";
            this.zeroBreak.Size = new System.Drawing.Size(31, 20);
            this.zeroBreak.TabIndex = 37;
            this.zeroBreak.Text = "0";
            this.zeroBreak.UseVisualStyleBackColor = true;
            this.zeroBreak.Click += new System.EventHandler(this.zeroBreak_Click);
            // 
            // kmDriven
            // 
            this.kmDriven.Location = new System.Drawing.Point(112, 155);
            this.kmDriven.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.kmDriven.Name = "kmDriven";
            this.kmDriven.Size = new System.Drawing.Size(77, 20);
            this.kmDriven.TabIndex = 38;
            this.kmDriven.ValueChanged += new System.EventHandler(this.kmDriven_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Kilometers Gereden";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Location = new System.Drawing.Point(299, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Overuren deze maand:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // extraHoursLabel
            // 
            this.extraHoursLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.extraHoursLabel.Location = new System.Drawing.Point(299, 215);
            this.extraHoursLabel.Name = "extraHoursLabel";
            this.extraHoursLabel.Size = new System.Drawing.Size(127, 16);
            this.extraHoursLabel.TabIndex = 41;
            this.extraHoursLabel.Text = "0 uur";
            this.extraHoursLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Janus.Properties.Resources.kvtlogo_t;
            this.pictureBox1.Location = new System.Drawing.Point(306, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsCategory
            // 
            this.SettingsCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingsCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openOpslaglocatieToolStripMenuItem});
            this.SettingsCategory.Image = ((System.Drawing.Image)(resources.GetObject("SettingsCategory.Image")));
            this.SettingsCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsCategory.Name = "SettingsCategory";
            this.SettingsCategory.Size = new System.Drawing.Size(84, 22);
            this.SettingsCategory.Text = "Instellingen";
            this.SettingsCategory.ButtonClick += new System.EventHandler(this.SettingsCategory_ButtonClick);
            // 
            // openOpslaglocatieToolStripMenuItem
            // 
            this.openOpslaglocatieToolStripMenuItem.Name = "openOpslaglocatieToolStripMenuItem";
            this.openOpslaglocatieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openOpslaglocatieToolStripMenuItem.Text = "Open Opslaglocatie";
            this.openOpslaglocatieToolStripMenuItem.Click += new System.EventHandler(this.openOpslaglocatieToolStripMenuItem_Click);
            // 
            // saveMonthPDF
            // 
            this.saveMonthPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveMonthPDF.Image = ((System.Drawing.Image)(resources.GetObject("saveMonthPDF.Image")));
            this.saveMonthPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveMonthPDF.Name = "saveMonthPDF";
            this.saveMonthPDF.Size = new System.Drawing.Size(174, 22);
            this.saveMonthPDF.Text = "Maandrapportage PDF opslaan";
            this.saveMonthPDF.Click += new System.EventHandler(this.saveMonthPDF_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 256);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.extraHoursLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kmDriven);
            this.Controls.Add(this.zeroBreak);
            this.Controls.Add(this.autoEndHours);
            this.Controls.Add(this.fifteenMinuteBreak);
            this.Controls.Add(this.thirtyMinuteBreak);
            this.Controls.Add(this.breakMinutesInput);
            this.Controls.Add(this.setEndToNow);
            this.Controls.Add(this.setStartToNow);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.SundayName);
            this.Controls.Add(this.SaturdayName);
            this.Controls.Add(this.FridayName);
            this.Controls.Add(this.ThursdayName);
            this.Controls.Add(this.WednesdayName);
            this.Controls.Add(this.TuesdayName);
            this.Controls.Add(this.MondayName);
            this.Controls.Add(this.SundayDelta);
            this.Controls.Add(this.SaturdayDelta);
            this.Controls.Add(this.FridayDelta);
            this.Controls.Add(this.ThursdayDelta);
            this.Controls.Add(this.WednesdayDelta);
            this.Controls.Add(this.TuesdayDelta);
            this.Controls.Add(this.MondayDelta);
            this.Controls.Add(this.SundayHours);
            this.Controls.Add(this.SaturdayHours);
            this.Controls.Add(this.FridayHours);
            this.Controls.Add(this.ThursdayHours);
            this.Controls.Add(this.WednesdayHours);
            this.Controls.Add(this.TuesdayHours);
            this.Controls.Add(this.MondayHours);
            this.Controls.Add(this.dayHeaderLabel);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.previousDayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Janus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakMinutesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmDriven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previousDayButton;
        private System.Windows.Forms.Button nextDayButton;
        private System.Windows.Forms.Label dayHeaderLabel;
        private System.Windows.Forms.Label MondayHours;
        private System.Windows.Forms.Label TuesdayHours;
        private System.Windows.Forms.Label WednesdayHours;
        private System.Windows.Forms.Label ThursdayHours;
        private System.Windows.Forms.Label FridayHours;
        private System.Windows.Forms.Label SaturdayHours;
        private System.Windows.Forms.Label SundayHours;
        private System.Windows.Forms.Label SundayDelta;
        private System.Windows.Forms.Label SaturdayDelta;
        private System.Windows.Forms.Label FridayDelta;
        private System.Windows.Forms.Label ThursdayDelta;
        private System.Windows.Forms.Label WednesdayDelta;
        private System.Windows.Forms.Label TuesdayDelta;
        private System.Windows.Forms.Label MondayDelta;
        private System.Windows.Forms.Label SundayName;
        private System.Windows.Forms.Label SaturdayName;
        private System.Windows.Forms.Label FridayName;
        private System.Windows.Forms.Label ThursdayName;
        private System.Windows.Forms.Label WednesdayName;
        private System.Windows.Forms.Label TuesdayName;
        private System.Windows.Forms.Label MondayName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton SettingsCategory;
        private System.Windows.Forms.ToolStripMenuItem openOpslaglocatieToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Button setStartToNow;
        private System.Windows.Forms.Button setEndToNow;
        private System.Windows.Forms.NumericUpDown breakMinutesInput;
        private System.Windows.Forms.Button thirtyMinuteBreak;
        private System.Windows.Forms.Button fifteenMinuteBreak;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button autoEndHours;
        private System.Windows.Forms.Button zeroBreak;
        private System.Windows.Forms.NumericUpDown kmDriven;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label extraHoursLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton saveMonthPDF;
    }
}

