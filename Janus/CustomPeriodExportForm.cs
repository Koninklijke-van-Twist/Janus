using System;
using System.Windows.Forms;

namespace Janus
{
    public partial class CustomPeriodExportForm : Form
    {
        public DateTime LastSelectedStartDate, LastSelectedEndDate;

        public CustomPeriodExportForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;

            datePickerStart.Value = DateTime.Now - TimeSpan.FromDays(31);
            datePickerEnd.Value = DateTime.Now;

            LastSelectedStartDate = DateTime.Now - TimeSpan.FromDays(31);
            LastSelectedEndDate = DateTime.Now;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void datePickerStart_ValueChanged(object sender, EventArgs e)
        {
            if(datePickerEnd.Value.Date < datePickerStart.Value.Date + TimeSpan.FromDays(1)) 
                datePickerEnd.Value = datePickerStart.Value + TimeSpan.FromDays(1);

            LastSelectedStartDate = datePickerStart.Value.Date;
            LastSelectedEndDate = datePickerEnd.Value.Date;
        }

        private void datePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            if (datePickerEnd.Value.Date < datePickerStart.Value.Date + TimeSpan.FromDays(1))
                datePickerEnd.Value = datePickerStart.Value + TimeSpan.FromDays(1);

            LastSelectedStartDate = datePickerStart.Value.Date;
            LastSelectedEndDate = datePickerEnd.Value.Date;
        }
    }
}
