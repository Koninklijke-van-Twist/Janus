using System;
using System.Collections.Generic;

namespace Janus
{
    public class SaveData
    {
        public string UserName, UserEmail;

        public TimeSpan MondayHours = TimeSpan.FromHours(8);
        public TimeSpan TuesdayHours = TimeSpan.FromHours(8);
        public TimeSpan WednesdayHours = TimeSpan.FromHours(8);
        public TimeSpan ThursdayHours = TimeSpan.FromHours(8);
        public TimeSpan FridayHours = TimeSpan.FromHours(8);
        public TimeSpan SaturdayHours = TimeSpan.FromHours(0);
        public TimeSpan SundayHours = TimeSpan.FromHours(0);

        public Dictionary<DaySelector, DayData> SavedDays = new Dictionary<DaySelector, DayData>();
        public DayData GetDay(DaySelector day)
        {
            if (!SavedDays.ContainsKey(day))
            {
                SavedDays.Add(day, new DayData());
            }

            return SavedDays[day];
        }

        public TimeSpan GetWorkHoursForDayNumber(int number)
        {
            switch (number)
            {
                case 0: return MondayHours;
                case 1: return TuesdayHours;
                case 2: return WednesdayHours;
                case 3: return ThursdayHours;
                case 4: return FridayHours;
                case 5: return SaturdayHours;
                case 6: return SundayHours;
            }

            return TimeSpan.Zero;
        }

        public void EnsureDayDataExists(DaySelector day)
        {
            if (!SavedDays.ContainsKey(day))
            {
                SavedDays.Add(day, new DayData());
            }
        }

        public class DayData
        {
            public TimeSpan StartTime;
            public TimeSpan EndTime;
            public int BreakMinutes;
            public decimal Kilometers;
            public bool isHoliday = false;

            public TimeSpan WorkedTime => (EndTime - StartTime).Subtract(TimeSpan.FromMinutes(BreakMinutes));
            public string WorkedString => $"{WorkedTime.Hours} uur, {WorkedTime.Minutes} {(WorkedTime.Minutes == 1? "minuut" : "minuten")}";

            public DayData()
            {
                StartTime = TimeSpan.FromHours(9);
                EndTime = TimeSpan.FromHours(17.5);
                BreakMinutes = 30;
            }
        }

        public struct DaySelector
        {
            public int Day, Month, Year;

            public DaySelector(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public static implicit operator DaySelector(DateTime date)
            {
                return new DaySelector(date.Day, date.Month, date.Year);
            }

            public override string ToString()
            {
                return $"{Day.ToString("d2")}-{Month.ToString("d2")}-{Year}";
            }

            // Required for JSON parsing
            public static implicit operator DaySelector(string s)
            {
                if (string.IsNullOrWhiteSpace(s))
                    throw new ArgumentNullException(nameof(s), "Input string cannot be null or empty.");

                string[] parts = s.Split('-');
                if (parts.Length != 3)
                    throw new FormatException("Input string must be in format dd-MM-yyyy.");

                return new DaySelector
                {
                    Day = int.Parse(parts[0]),
                    Month = int.Parse(parts[1]),
                    Year = int.Parse(parts[2])
                };
            }
        }
    }
}
