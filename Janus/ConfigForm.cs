using System;
using System.Windows.Forms;

namespace Janus
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            mondayHoursPicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, MainForm.SaveData.MondayHours.Hours, MainForm.SaveData.MondayHours.Minutes, 0);
            tuesdayHoursPicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, MainForm.SaveData.TuesdayHours.Hours, MainForm.SaveData.TuesdayHours.Minutes, 0);
            wednesdayHoursPicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, MainForm.SaveData.WednesdayHours.Hours, MainForm.SaveData.WednesdayHours.Minutes, 0);
            thursdayHoursPicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, MainForm.SaveData.ThursdayHours.Hours, MainForm.SaveData.ThursdayHours.Minutes, 0);
            fridayHoursPicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, MainForm.SaveData.FridayHours.Hours, MainForm.SaveData.FridayHours.Minutes, 0);
            saturdayHoursPicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, MainForm.SaveData.SaturdayHours.Hours, MainForm.SaveData.SaturdayHours.Minutes, 0);
            sundayHoursPicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, MainForm.SaveData.SundayHours.Hours, MainForm.SaveData.SundayHours.Minutes, 0);
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void mondayHoursPicker_ValueChanged(object sender, EventArgs e)
        {
            MainForm.SaveData.MondayHours = mondayHoursPicker.Value.TimeOfDay;
        }

        private void tuesdayHoursPicker_ValueChanged(object sender, EventArgs e)
        {
            MainForm.SaveData.TuesdayHours = tuesdayHoursPicker.Value.TimeOfDay;
        }

        private void wednesdayHoursPicker_ValueChanged(object sender, EventArgs e)
        {
            MainForm.SaveData.WednesdayHours = wednesdayHoursPicker.Value.TimeOfDay;
        }

        private void thursdayHoursPicker_ValueChanged(object sender, EventArgs e)
        {
            MainForm.SaveData.ThursdayHours = thursdayHoursPicker.Value.TimeOfDay;
        }

        private void fridayHoursPicker_ValueChanged(object sender, EventArgs e)
        {
            MainForm.SaveData.FridayHours = fridayHoursPicker.Value.TimeOfDay;
        }

        private void saturdayHoursPicker_ValueChanged(object sender, EventArgs e)
        {
            MainForm.SaveData.SaturdayHours = saturdayHoursPicker.Value.TimeOfDay;
        }

        private void sundayHoursPicker_ValueChanged(object sender, EventArgs e)
        {
            MainForm.SaveData.SundayHours = sundayHoursPicker.Value.TimeOfDay;
        }
    }
}
