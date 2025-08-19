using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Janus
{
    public partial class MainForm : Form
    {
        #region Static Variables

        public static SaveData SaveData;

        #endregion

        #region Private Variables

        private DateTime _currentSelecedDay;
        private string _userName, _userEmail;

        #endregion

        #region Properties

        private SaveData.DayData CurrentDayData => SaveData.SavedDays[_currentSelecedDay];
        private string _saveDirectory => $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\Janus";

        #endregion

        public MainForm()
        {
            InitializeComponent();
            Load();
            GetUserData();
            _currentSelecedDay = DateTime.Now;
            LoadDay();
        }

        #region Events

        private void SettingsCategory_ButtonClick(object sender, EventArgs e)
        {
            new ConfigForm().ShowDialog();
            Save();
        }

        private void openOpslaglocatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(_saveDirectory);
            Process.Start(_saveDirectory);
        }

        private void previousDayButton_Click(object sender, EventArgs e)
        {
            Save();
            _currentSelecedDay = _currentSelecedDay.Subtract(TimeSpan.FromDays(1));
            LoadDay();
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Date > _currentSelecedDay.Date)
            {
                Save();
                _currentSelecedDay = _currentSelecedDay.Add(TimeSpan.FromDays(1));
                LoadDay();
            }
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (endTimePicker.Value.TimeOfDay < startTimePicker.Value.TimeOfDay)
            {
                endTimePicker.Value = endTimePicker.Value.AddMinutes(startTimePicker.Value.TimeOfDay.TotalMinutes - endTimePicker.Value.TimeOfDay.TotalMinutes);
            }

            SetTodayHoursWorked();
        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(endTimePicker.Value.TimeOfDay < startTimePicker.Value.TimeOfDay)
            {
                endTimePicker.Value = endTimePicker.Value.AddMinutes(startTimePicker.Value.TimeOfDay.TotalMinutes - endTimePicker.Value.TimeOfDay.TotalMinutes);
            }

            SetTodayHoursWorked();
        }


        private void breakMinutesInput_ValueChanged(object sender, EventArgs e)
        {
            SetTodayHoursWorked();
        }

        private void thirtyMinuteBreak_Click(object sender, EventArgs e)
        {
            breakMinutesInput.Value = 30;
            SetTodayHoursWorked();
        }

        private void fifteenMinuteBreak_Click(object sender, EventArgs e)
        {
            breakMinutesInput.Value = 15;
            SetTodayHoursWorked();
        }

        private void zeroBreak_Click(object sender, EventArgs e)
        {
            breakMinutesInput.Value = 0;
            SetTodayHoursWorked();
        }

        private void kmDriven_ValueChanged(object sender, EventArgs e)
        {
            SaveData.EnsureDayDataExists(_currentSelecedDay);
            SaveData.SavedDays[_currentSelecedDay].Kilometers = kmDriven.Value;
        }

        private void autoEndHours_Click(object sender, EventArgs e)
        {
            SaveData.DayData day = SaveData.GetDay(_currentSelecedDay);
            DateTime now = _currentSelecedDay;

            DateTime start = new DateTime(now.Year, now.Month, now.Day, day.StartTime.Hours, day.StartTime.Minutes, 0);

            int dayNumber = ((int)_currentSelecedDay.DayOfWeek + 6) % 7; // Monday = 0, Sunday = 6
            DateTime end = start.Add(SaveData.GetWorkHoursForDayNumber(dayNumber)).AddMinutes(day.BreakMinutes);

            SaveData.SavedDays[_currentSelecedDay].EndTime = end.TimeOfDay;
            endTimePicker.Value = end;
        }

        private void setStartToNow_Click(object sender, EventArgs e)
        {
            startTimePicker.Value = DateTime.Now;

            if (endTimePicker.Value.TimeOfDay < startTimePicker.Value.TimeOfDay)
            {
                endTimePicker.Value = endTimePicker.Value.AddMinutes(startTimePicker.Value.TimeOfDay.TotalMinutes - endTimePicker.Value.TimeOfDay.TotalMinutes);
            }

            SetTodayHoursWorked();
        }

        private void setEndToNow_Click(object sender, EventArgs e)
        {
            endTimePicker.Value = DateTime.Now;

            if (endTimePicker.Value.TimeOfDay < startTimePicker.Value.TimeOfDay)
            {
                endTimePicker.Value = endTimePicker.Value.AddMinutes(startTimePicker.Value.TimeOfDay.TotalMinutes - endTimePicker.Value.TimeOfDay.TotalMinutes);
            }

            SetTodayHoursWorked();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void saveMonthPDF_Click(object sender, EventArgs e)
        {
            CultureInfo dutch = new CultureInfo("nl-NL");
            string formatted = _currentSelecedDay.ToString("MMMM yyyy", dutch);

            saveFileDialog1.FileName = $"{_userName} - uren {formatted}";

            if (saveFileDialog1.ShowDialog() is DialogResult.OK)
            {
                CreatePDF(saveFileDialog1.FileName);
            }
        }

        #endregion

        #region Private Methods

        private void SetTodayHoursWorked()
        {
            SaveData.EnsureDayDataExists(_currentSelecedDay);

            CurrentDayData.StartTime = startTimePicker.Value.TimeOfDay;
            CurrentDayData.EndTime = endTimePicker.Value.TimeOfDay;
            CurrentDayData.BreakMinutes = (int)breakMinutesInput.Value;

            CultureInfo dutch = new CultureInfo("nl-NL");
            string formatted = _currentSelecedDay.ToString("dddd dd MMMM yyyy", dutch);

            dayHeaderLabel.Text = $"{formatted} - {CurrentDayData.WorkedTime.Hours} uur, {CurrentDayData.WorkedTime.Minutes} {(CurrentDayData.WorkedTime.Minutes == 1 ? "minuut" : "minuten")} gewerkt";

            int diff = ((int)_currentSelecedDay.DayOfWeek + 6) % 7; // Monday = 0, Sunday = 6
            DateTime monday = _currentSelecedDay.AddDays(-diff);

            for (int i = 0; i < 7; i++)
            {
                DateTime day = monday.AddDays(i);

                string hoursText = "";
                int minutes = 0;

                if (SaveData.SavedDays.ContainsKey(day))
                {
                    hoursText = $"{SaveData.GetDay(day).WorkedTime.Hours.ToString("d2")}:{SaveData.GetDay(day).WorkedTime.Minutes.ToString("d2")}";
                    minutes = (int)(SaveData.GetDay(day).WorkedTime - SaveData.GetWorkHoursForDayNumber(i)).TotalMinutes;
                }

                System.Drawing.Color selected = System.Drawing.Color.FromArgb(255, 104, 199, 231);
                System.Drawing.Color unselected = System.Drawing.Color.FromArgb(255, 240, 240, 240);

                switch (i)
                {
                    case 0:
                        MondayName.BackColor = day.Date == _currentSelecedDay.Date ? selected : unselected;

                        if (SaveData.SavedDays.ContainsKey(day))
                        {
                            MondayHours.Text = hoursText;
                            MondayDelta.Text = minutes.ToString("+0;-0;0");
                            MondayDelta.BackColor = minutes > 0 ? System.Drawing.Color.LightGreen : minutes < 0 ? System.Drawing.Color.PaleVioletRed : System.Drawing.Color.LightGray;
                        }
                        else
                        {
                            MondayHours.Text = "";
                            MondayDelta.Text = "";
                            MondayDelta.BackColor = unselected;
                        }
                        break;

                    case 1:
                        TuesdayName.BackColor = day.Date == _currentSelecedDay.Date ? selected : unselected;

                        if (SaveData.SavedDays.ContainsKey(day))
                        {
                            TuesdayHours.Text = hoursText;
                            TuesdayDelta.Text = minutes.ToString("+0;-0;0");
                            TuesdayDelta.BackColor = minutes > 0 ? System.Drawing.Color.LightGreen : minutes < 0 ? System.Drawing.Color.PaleVioletRed : System.Drawing.Color.LightGray;
                        }
                        else
                        {
                            TuesdayHours.Text = "";
                            TuesdayDelta.Text = "";
                            TuesdayDelta.BackColor = unselected;
                        }
                        break;

                    case 2:
                        WednesdayName.BackColor = day.Date == _currentSelecedDay.Date ? selected : unselected;

                        if (SaveData.SavedDays.ContainsKey(day))
                        {
                            WednesdayHours.Text = hoursText;
                            WednesdayDelta.Text = minutes.ToString("+0;-0;0");
                            WednesdayDelta.BackColor = minutes > 0 ? System.Drawing.Color.LightGreen : minutes < 0 ? System.Drawing.Color.PaleVioletRed : System.Drawing.Color.LightGray;
                        }
                        else
                        {
                            WednesdayHours.Text = "";
                            WednesdayDelta.Text = "";
                            WednesdayDelta.BackColor = unselected;
                        }
                        break;

                    case 3:
                        ThursdayName.BackColor = day.Date == _currentSelecedDay.Date ? selected : unselected;

                        if (SaveData.SavedDays.ContainsKey(day))
                        {
                            ThursdayHours.Text = hoursText;
                            ThursdayDelta.Text = minutes.ToString("+0;-0;0");
                            ThursdayDelta.BackColor = minutes > 0 ? System.Drawing.Color.LightGreen : minutes < 0 ? System.Drawing.Color.PaleVioletRed : System.Drawing.Color.LightGray;
                        }
                        else
                        {
                            ThursdayHours.Text = "";
                            ThursdayDelta.Text = "";
                            ThursdayDelta.BackColor = unselected;
                        }
                        break;

                    case 4:
                        FridayName.BackColor = day.Date == _currentSelecedDay.Date ? selected : unselected;

                        if (SaveData.SavedDays.ContainsKey(day))
                        {
                            FridayHours.Text = hoursText;
                            FridayDelta.Text = minutes.ToString("+0;-0;0");
                            FridayDelta.BackColor = minutes > 0 ? System.Drawing.Color.LightGreen : minutes < 0 ? System.Drawing.Color.PaleVioletRed : System.Drawing.Color.LightGray;
                        }
                        else
                        {
                            FridayHours.Text = "";
                            FridayDelta.Text = "";
                            FridayDelta.BackColor = unselected;
                        }
                        break;

                    case 5:
                        SaturdayName.BackColor = day.Date == _currentSelecedDay.Date ? selected : unselected;

                        if (SaveData.SavedDays.ContainsKey(day))
                        {
                            SaturdayHours.Text = hoursText;
                            SaturdayDelta.Text = minutes.ToString("+0;-0;0");
                            SaturdayDelta.BackColor = minutes > 0 ? System.Drawing.Color.LightGreen : minutes < 0 ? System.Drawing.Color.PaleVioletRed : System.Drawing.Color.LightGray;
                        }
                        else
                        {
                            SaturdayHours.Text = "";
                            SaturdayDelta.Text = "";
                            SaturdayDelta.BackColor = unselected;
                        }
                        break;

                    case 6:
                        SundayName.BackColor = day.Date == _currentSelecedDay.Date ? selected : unselected;

                        if (SaveData.SavedDays.ContainsKey(day))
                        {
                            SundayHours.Text = hoursText;
                            SundayDelta.Text = minutes.ToString("+0;-0;0");
                            SundayDelta.BackColor = minutes > 0 ? System.Drawing.Color.LightGreen : minutes < 0 ? System.Drawing.Color.PaleVioletRed : System.Drawing.Color.LightGray;
                        }
                        else
                        {
                            SundayHours.Text = "";
                            SundayDelta.Text = "";
                            SundayDelta.BackColor = unselected;
                        }
                        break;
                }
            }

            TimeSpan extraHours = CalculateExtraHours();

            string extraHoursFormatted = string.Format("{0}{1:00}:{2:00}",
                extraHours.Ticks < 0 ? "-" : "+",
                Math.Abs((int)extraHours.TotalHours),
                Math.Abs(extraHours.Minutes));

            extraHoursLabel.Text = extraHoursFormatted;
            extraHoursLabel.ForeColor = extraHours > TimeSpan.Zero ? System.Drawing.Color.DarkGreen : extraHours < TimeSpan.Zero ? System.Drawing.Color.DarkRed : System.Drawing.Color.Black;
        }

        private void Load()
        {
            try
            {
                string json = File.ReadAllText(Path.Combine(_saveDirectory, "savedata.json"));
                SaveData = Newtonsoft.Json.JsonConvert.DeserializeObject<SaveData>(json) ?? new SaveData();
            }
            catch (Exception e)
            {
                SaveData = new SaveData();
                MessageBox.Show($"Opgeslagen data niet gevonden, nieuw opslagbestand aangemaakt.\n\n{e}");
                SaveData.SavedDays[DateTime.Now] = new SaveData.DayData();
                Save();
            }
        }

        private void Save()
        {
            string jsonConfig = Newtonsoft.Json.JsonConvert.SerializeObject(SaveData);

            Directory.CreateDirectory(_saveDirectory);
            string configPath = Path.Combine(_saveDirectory, "savedata.json");

            File.WriteAllText(configPath, jsonConfig);
        }

        private void GetUserData()
        {
            using (PrincipalContext ctx = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal user = UserPrincipal.Current;

                _userName = user.DisplayName;
                _userEmail = user.EmailAddress;
            }
        }

        private void LoadDay()
        {
            bool shouldBeInitialized = !SaveData.SavedDays.ContainsKey(_currentSelecedDay);

            SaveData.DayData day = SaveData.GetDay(_currentSelecedDay);
            DateTime now = _currentSelecedDay;
            DateTime start = new DateTime(now.Year, now.Month, now.Day, day.StartTime.Hours, day.StartTime.Minutes, 0);
            DateTime end = new DateTime(now.Year, now.Month, now.Day, day.EndTime.Hours, day.EndTime.Minutes, 0);

            if(shouldBeInitialized)
            {
                int dayNumber = ((int)_currentSelecedDay.DayOfWeek + 6) % 7; // Monday = 0, Sunday = 6
                day.BreakMinutes = 0;
                end = start.Add(SaveData.GetWorkHoursForDayNumber(dayNumber)).AddMinutes(day.BreakMinutes);

                SaveData.SavedDays[_currentSelecedDay].EndTime = end.TimeOfDay;
                SaveData.SavedDays[_currentSelecedDay].BreakMinutes = 0;
            }

            breakMinutesInput.Value = day.BreakMinutes;
            kmDriven.Value = day.Kilometers;
            startTimePicker.Value = start;
            endTimePicker.Value = end;

            SetTodayHoursWorked();
            nextDayButton.Enabled = DateTime.Now.Date > _currentSelecedDay.Date;
        }

        private TimeSpan CalculateExtraHours()
        {
            TimeSpan extraHours = TimeSpan.Zero;

            DateTime firstDay = new DateTime(_currentSelecedDay.Year, _currentSelecedDay.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(_currentSelecedDay.Year, _currentSelecedDay.Month);
            DateTime lastDay = new DateTime(_currentSelecedDay.Year, _currentSelecedDay.Month, daysInMonth);

            for (DateTime day = firstDay; day <= lastDay; day = day.AddDays(1))
            {
                if (SaveData.SavedDays.ContainsKey(day) && SaveData.SavedDays[day].WorkedTime > TimeSpan.Zero)
                {
                    int dayNumber = ((int)day.DayOfWeek + 6) % 7;
                    TimeSpan OverTime = TimeSpan.FromMinutes((SaveData.GetDay(day).WorkedTime - SaveData.GetWorkHoursForDayNumber(dayNumber)).TotalMinutes);
                    extraHours = extraHours.Add(OverTime);
                }
            }

            return extraHours;
        }

        private void CreatePDF(string savePath)
        {
            CultureInfo dutch = new CultureInfo("nl-NL");
            string monthYear = _currentSelecedDay.ToString("MMMM yyyy", dutch);

            PdfDocument document = new PdfDocument();
            document.Info.Title = $"{_userName} - uren {monthYear}";

            GlobalFontSettings.FontResolver = new FileFontResolver();

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            string headerLogo = $"{Application.StartupPath}\\Resources\\kvt-logo.png";
            if (File.Exists(headerLogo))
            {
                XImage headerImage = XImage.FromFile(headerLogo);
                gfx.DrawImage(headerImage, 50, 20, 200, 50);
            }

            // Fonts
            XFont fontBig = new XFont("Verdana", 24, XFontStyleEx.Regular);
            XFont fontRegular = new XFont("Verdana", 12, XFontStyleEx.Regular);
            XFont fontBold = new XFont("Verdana", 12, XFontStyleEx.Bold);

            XBrush kvtBrush = new XSolidBrush(XColor.FromArgb(0, 82, 155));
            XBrush kvtBgBrush = new XSolidBrush(XColor.FromArgb(0, 153, 204));

            // Write user details
            gfx.DrawString($"{_userName}, {monthYear}", fontBig, kvtBrush, new XRect(50, 100, page.Width, 30), XStringFormats.TopLeft);
            gfx.DrawString($"{_userEmail}", fontRegular, kvtBrush, new XRect(50, 130, page.Width, 20), XStringFormats.TopLeft);

            List<(DateTime, SaveData.DayData)> monthdays = new List<(DateTime, SaveData.DayData)>();

            // Find first and last day of that month
            DateTime firstDay = new DateTime(_currentSelecedDay.Year, _currentSelecedDay.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(_currentSelecedDay.Year, _currentSelecedDay.Month);
            DateTime lastDay = new DateTime(_currentSelecedDay.Year, _currentSelecedDay.Month, daysInMonth);

            TimeSpan extraHours = TimeSpan.Zero;

            // Loop through all days
            for (DateTime day = firstDay; day <= lastDay; day = day.AddDays(1))
            {
                if (SaveData.SavedDays.ContainsKey(day) && (SaveData.SavedDays[day].WorkedTime > TimeSpan.Zero || SaveData.SavedDays[day].Kilometers >= 0))
                {
                    monthdays.Add((day, SaveData.GetDay(day)));

                    int dayNumber = ((int)day.DayOfWeek + 6) % 7;
                    TimeSpan OverTime = TimeSpan.FromMinutes((SaveData.GetDay(day).WorkedTime - SaveData.GetWorkHoursForDayNumber(dayNumber)).TotalMinutes);
                    extraHours = extraHours.Add(OverTime);
                }
            }

            int y = 160;
            int rowHeight = 25;
            decimal totalKm = 0;

            // Table column positions
            int xDate = 50;
            int xHours = 250;
            int xKm = 400;

            // Table header
            gfx.DrawString("Datum", fontBold, kvtBrush, new XRect(xDate, y, 200, rowHeight), XStringFormats.CenterLeft);
            gfx.DrawString("Gewerkte uren", fontBold, kvtBrush, new XRect(xHours, y, 100, rowHeight), XStringFormats.CenterLeft);
            gfx.DrawString("Gereden Kilometers", fontBold, kvtBrush, new XRect(xKm, y, 100, rowHeight), XStringFormats.CenterLeft);
            y += rowHeight;

            bool shade = false;

            foreach ((DateTime, SaveData.DayData) row in monthdays)
            {
                if (row.Item2.WorkedTime == TimeSpan.Zero)
                    continue;

                if (shade)
                {
                    gfx.DrawRectangle(XBrushes.LightGray, xDate, y - 4, page.Width - 100, rowHeight);
                }

                gfx.DrawString(row.Item1.ToString("dd MMMM (dddd)", dutch), fontRegular, kvtBrush,
                    new XRect(xDate, y, 200, rowHeight), XStringFormats.CenterLeft);

                gfx.DrawString(row.Item2.WorkedString, fontRegular, kvtBrush,
                    new XRect(xHours, y, 100, rowHeight), XStringFormats.CenterLeft);

                gfx.DrawString($"{row.Item2.Kilometers.ToString()} km", fontRegular, kvtBrush,
                    new XRect(xKm, y, 100, rowHeight), XStringFormats.CenterLeft);

                totalKm += row.Item2.Kilometers;
                y += rowHeight;
                shade = !shade;
            }

            y = 785;
            
            if (extraHours > TimeSpan.Zero)
            {
                gfx.DrawString($"Overgewerkt: {Math.Floor(extraHours.TotalHours)} uur, {extraHours.Minutes} {(extraHours.Minutes == 1 ? "minuut" : "minuten")}", fontBold, kvtBrush, new XRect(50, y, 200, rowHeight), XStringFormats.CenterLeft);
                y += rowHeight;
            }

            gfx.DrawString($"Totaal kilometers gereden: {totalKm}", fontBold, kvtBrush, new XRect(50, y, 200, rowHeight), XStringFormats.CenterLeft);


            double pageWidth = page.Width;
            double pageHeight = page.Height;

            string label = "Vaste Werkdagen:";
            XSize labelSize = gfx.MeasureString(label, fontRegular);

            string[,] days = { { "Ma", "Di", "Wo", "Do" }, { "Vr", "Za", "Zo", "" } }; // note: last empty cell for 4x2
                bool[,] isActive = {
                { SaveData.MondayHours > TimeSpan.Zero, SaveData.TuesdayHours > TimeSpan.Zero, SaveData.WednesdayHours > TimeSpan.Zero, SaveData.ThursdayHours > TimeSpan.Zero },
                { SaveData.FridayHours > TimeSpan.Zero, SaveData.SaturdayHours > TimeSpan.Zero, SaveData.SundayHours > TimeSpan.Zero, false }
            };

            int cols = 4;
            int rows = 2;
            double squareWidth = 20;  // adjust for two characters
            double squareHeight = 15;

            double spacing = 5;
            double gridWidth = cols * squareWidth + (cols - 1) * spacing;
            double gridHeight = rows * squareHeight + (rows - 1) * spacing;
            double startX = pageWidth - gridWidth - 50; // 50 units margin from right
            double startY = 792;
            gfx.DrawString(label, fontRegular, kvtBrush, startX - labelSize.Width - 10, startY + gridHeight / 2 - labelSize.Height / 2);

            XFont squareFont = new XFont("Verdana", 8, XFontStyleEx.Regular);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (string.IsNullOrEmpty(days[r, c]))
                        continue; // skip empty cells

                    double sx = startX + c * (squareWidth + spacing);
                    double sy = startY + r * (squareHeight + spacing);

                    // Background colour
                    XBrush brush = isActive[r, c] ? kvtBgBrush : XBrushes.LightGray;
                    gfx.DrawRectangle(brush, sx, sy, squareWidth, squareHeight);

                    // Draw day abbreviation centered
                    XSize textSize = gfx.MeasureString(days[r, c], squareFont);
                    double textX = sx + (squareWidth - textSize.Width) / 2;
                    double textY = sy + (squareHeight / 1.5);
                    gfx.DrawString(days[r, c], squareFont, isActive[r, c] ? kvtBrush : XBrushes.Gray, textX, textY);
                }
            }

            document.Save(savePath);
            Process.Start("explorer.exe", Directory.GetParent(savePath).FullName);
        }

        #endregion
    }
}
