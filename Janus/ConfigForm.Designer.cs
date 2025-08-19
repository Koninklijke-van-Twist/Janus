namespace Janus
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.mondayHoursPicker = new System.Windows.Forms.DateTimePicker();
            this.SundayName = new System.Windows.Forms.Label();
            this.SaturdayName = new System.Windows.Forms.Label();
            this.FridayName = new System.Windows.Forms.Label();
            this.ThursdayName = new System.Windows.Forms.Label();
            this.WednesdayName = new System.Windows.Forms.Label();
            this.TuesdayName = new System.Windows.Forms.Label();
            this.MondayName = new System.Windows.Forms.Label();
            this.tuesdayHoursPicker = new System.Windows.Forms.DateTimePicker();
            this.wednesdayHoursPicker = new System.Windows.Forms.DateTimePicker();
            this.thursdayHoursPicker = new System.Windows.Forms.DateTimePicker();
            this.fridayHoursPicker = new System.Windows.Forms.DateTimePicker();
            this.saturdayHoursPicker = new System.Windows.Forms.DateTimePicker();
            this.sundayHoursPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mondayHoursPicker
            // 
            this.mondayHoursPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mondayHoursPicker.CustomFormat = "HH:mm";
            this.mondayHoursPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mondayHoursPicker.Location = new System.Drawing.Point(95, 34);
            this.mondayHoursPicker.Name = "mondayHoursPicker";
            this.mondayHoursPicker.ShowUpDown = true;
            this.mondayHoursPicker.Size = new System.Drawing.Size(77, 20);
            this.mondayHoursPicker.TabIndex = 29;
            this.mondayHoursPicker.Value = new System.DateTime(2025, 8, 19, 8, 0, 0, 0);
            this.mondayHoursPicker.ValueChanged += new System.EventHandler(this.mondayHoursPicker_ValueChanged);
            // 
            // SundayName
            // 
            this.SundayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SundayName.Location = new System.Drawing.Point(12, 194);
            this.SundayName.Name = "SundayName";
            this.SundayName.Size = new System.Drawing.Size(65, 16);
            this.SundayName.TabIndex = 36;
            this.SundayName.Text = "Zondag";
            this.SundayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SaturdayName
            // 
            this.SaturdayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaturdayName.Location = new System.Drawing.Point(12, 168);
            this.SaturdayName.Name = "SaturdayName";
            this.SaturdayName.Size = new System.Drawing.Size(65, 16);
            this.SaturdayName.TabIndex = 35;
            this.SaturdayName.Text = "Zaterdag";
            this.SaturdayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FridayName
            // 
            this.FridayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FridayName.Location = new System.Drawing.Point(12, 142);
            this.FridayName.Name = "FridayName";
            this.FridayName.Size = new System.Drawing.Size(65, 16);
            this.FridayName.TabIndex = 34;
            this.FridayName.Text = "Vrijdag";
            this.FridayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ThursdayName
            // 
            this.ThursdayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThursdayName.Location = new System.Drawing.Point(12, 116);
            this.ThursdayName.Name = "ThursdayName";
            this.ThursdayName.Size = new System.Drawing.Size(65, 16);
            this.ThursdayName.TabIndex = 33;
            this.ThursdayName.Text = "Donderdag";
            this.ThursdayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WednesdayName
            // 
            this.WednesdayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WednesdayName.Location = new System.Drawing.Point(12, 90);
            this.WednesdayName.Name = "WednesdayName";
            this.WednesdayName.Size = new System.Drawing.Size(65, 16);
            this.WednesdayName.TabIndex = 32;
            this.WednesdayName.Text = "Woensdag";
            this.WednesdayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TuesdayName
            // 
            this.TuesdayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TuesdayName.Location = new System.Drawing.Point(12, 64);
            this.TuesdayName.Name = "TuesdayName";
            this.TuesdayName.Size = new System.Drawing.Size(65, 16);
            this.TuesdayName.TabIndex = 31;
            this.TuesdayName.Text = "Dinsdag";
            this.TuesdayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MondayName
            // 
            this.MondayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MondayName.Location = new System.Drawing.Point(12, 38);
            this.MondayName.Name = "MondayName";
            this.MondayName.Size = new System.Drawing.Size(65, 16);
            this.MondayName.TabIndex = 30;
            this.MondayName.Text = "Maandag";
            this.MondayName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tuesdayHoursPicker
            // 
            this.tuesdayHoursPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tuesdayHoursPicker.CustomFormat = "HH:mm";
            this.tuesdayHoursPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tuesdayHoursPicker.Location = new System.Drawing.Point(95, 60);
            this.tuesdayHoursPicker.Name = "tuesdayHoursPicker";
            this.tuesdayHoursPicker.ShowUpDown = true;
            this.tuesdayHoursPicker.Size = new System.Drawing.Size(77, 20);
            this.tuesdayHoursPicker.TabIndex = 37;
            this.tuesdayHoursPicker.Value = new System.DateTime(2025, 8, 19, 8, 0, 0, 0);
            this.tuesdayHoursPicker.ValueChanged += new System.EventHandler(this.tuesdayHoursPicker_ValueChanged);
            // 
            // wednesdayHoursPicker
            // 
            this.wednesdayHoursPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wednesdayHoursPicker.CustomFormat = "HH:mm";
            this.wednesdayHoursPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.wednesdayHoursPicker.Location = new System.Drawing.Point(95, 86);
            this.wednesdayHoursPicker.Name = "wednesdayHoursPicker";
            this.wednesdayHoursPicker.ShowUpDown = true;
            this.wednesdayHoursPicker.Size = new System.Drawing.Size(77, 20);
            this.wednesdayHoursPicker.TabIndex = 38;
            this.wednesdayHoursPicker.Value = new System.DateTime(2025, 8, 19, 8, 0, 0, 0);
            this.wednesdayHoursPicker.ValueChanged += new System.EventHandler(this.wednesdayHoursPicker_ValueChanged);
            // 
            // thursdayHoursPicker
            // 
            this.thursdayHoursPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thursdayHoursPicker.CustomFormat = "HH:mm";
            this.thursdayHoursPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.thursdayHoursPicker.Location = new System.Drawing.Point(95, 112);
            this.thursdayHoursPicker.Name = "thursdayHoursPicker";
            this.thursdayHoursPicker.ShowUpDown = true;
            this.thursdayHoursPicker.Size = new System.Drawing.Size(77, 20);
            this.thursdayHoursPicker.TabIndex = 39;
            this.thursdayHoursPicker.Value = new System.DateTime(2025, 8, 19, 8, 0, 0, 0);
            this.thursdayHoursPicker.ValueChanged += new System.EventHandler(this.thursdayHoursPicker_ValueChanged);
            // 
            // fridayHoursPicker
            // 
            this.fridayHoursPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fridayHoursPicker.CustomFormat = "HH:mm";
            this.fridayHoursPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fridayHoursPicker.Location = new System.Drawing.Point(95, 138);
            this.fridayHoursPicker.Name = "fridayHoursPicker";
            this.fridayHoursPicker.ShowUpDown = true;
            this.fridayHoursPicker.Size = new System.Drawing.Size(77, 20);
            this.fridayHoursPicker.TabIndex = 40;
            this.fridayHoursPicker.Value = new System.DateTime(2025, 8, 19, 8, 0, 0, 0);
            this.fridayHoursPicker.ValueChanged += new System.EventHandler(this.fridayHoursPicker_ValueChanged);
            // 
            // saturdayHoursPicker
            // 
            this.saturdayHoursPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saturdayHoursPicker.CustomFormat = "HH:mm";
            this.saturdayHoursPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.saturdayHoursPicker.Location = new System.Drawing.Point(95, 164);
            this.saturdayHoursPicker.Name = "saturdayHoursPicker";
            this.saturdayHoursPicker.ShowUpDown = true;
            this.saturdayHoursPicker.Size = new System.Drawing.Size(77, 20);
            this.saturdayHoursPicker.TabIndex = 41;
            this.saturdayHoursPicker.Value = new System.DateTime(2025, 8, 19, 8, 0, 0, 0);
            this.saturdayHoursPicker.ValueChanged += new System.EventHandler(this.saturdayHoursPicker_ValueChanged);
            // 
            // sundayHoursPicker
            // 
            this.sundayHoursPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sundayHoursPicker.CustomFormat = "HH:mm";
            this.sundayHoursPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sundayHoursPicker.Location = new System.Drawing.Point(95, 190);
            this.sundayHoursPicker.Name = "sundayHoursPicker";
            this.sundayHoursPicker.ShowUpDown = true;
            this.sundayHoursPicker.Size = new System.Drawing.Size(77, 20);
            this.sundayHoursPicker.TabIndex = 42;
            this.sundayHoursPicker.Value = new System.DateTime(2025, 8, 19, 8, 0, 0, 0);
            this.sundayHoursPicker.ValueChanged += new System.EventHandler(this.sundayHoursPicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Werkuren per week";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sundayHoursPicker);
            this.Controls.Add(this.saturdayHoursPicker);
            this.Controls.Add(this.fridayHoursPicker);
            this.Controls.Add(this.thursdayHoursPicker);
            this.Controls.Add(this.wednesdayHoursPicker);
            this.Controls.Add(this.tuesdayHoursPicker);
            this.Controls.Add(this.SundayName);
            this.Controls.Add(this.SaturdayName);
            this.Controls.Add(this.FridayName);
            this.Controls.Add(this.ThursdayName);
            this.Controls.Add(this.WednesdayName);
            this.Controls.Add(this.TuesdayName);
            this.Controls.Add(this.MondayName);
            this.Controls.Add(this.mondayHoursPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigForm";
            this.Text = "Instellingen";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker mondayHoursPicker;
        private System.Windows.Forms.Label SundayName;
        private System.Windows.Forms.Label SaturdayName;
        private System.Windows.Forms.Label FridayName;
        private System.Windows.Forms.Label ThursdayName;
        private System.Windows.Forms.Label WednesdayName;
        private System.Windows.Forms.Label TuesdayName;
        private System.Windows.Forms.Label MondayName;
        private System.Windows.Forms.DateTimePicker tuesdayHoursPicker;
        private System.Windows.Forms.DateTimePicker wednesdayHoursPicker;
        private System.Windows.Forms.DateTimePicker thursdayHoursPicker;
        private System.Windows.Forms.DateTimePicker fridayHoursPicker;
        private System.Windows.Forms.DateTimePicker saturdayHoursPicker;
        private System.Windows.Forms.DateTimePicker sundayHoursPicker;
        private System.Windows.Forms.Label label1;
    }
}