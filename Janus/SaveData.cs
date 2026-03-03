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

        // New: persisted per-month extra hours (stored as ticks for durable JSON representation)
        // Keyed by MonthSelector so JSON keys will be readable like "02-2026"
        public Dictionary<MonthSelector, long> MonthExtraTicks = new Dictionary<MonthSelector, long>();

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

        // Constructor ensures newly added dictionary is present when deserializing older savedata.
        public SaveData()
        {
            if (MonthExtraTicks == null)
                MonthExtraTicks = new Dictionary<MonthSelector, long>();
        }

        #region Month extra-hours helpers

        // Get stored extra-hours for a specific month (returns TimeSpan.Zero if none)
        public TimeSpan GetSavedMonthExtra(int year, int month)
        {
            if (MonthExtraTicks == null)
                MonthExtraTicks = new Dictionary<MonthSelector, long>();

            var key = new MonthSelector(month, year);
            if (MonthExtraTicks.ContainsKey(key))
                return TimeSpan.FromTicks(MonthExtraTicks[key]);

            return TimeSpan.Zero;
        }

        // Persist/update stored extra-hours for a specific month
        public void SetSavedMonthExtra(int year, int month, TimeSpan value)
        {
            if (MonthExtraTicks == null)
                MonthExtraTicks = new Dictionary<MonthSelector, long>();

            var key = new MonthSelector(month, year);
            MonthExtraTicks[key] = value.Ticks;
        }

        // Consume 'amount' from previous month first, then from current month.
        // Returns the actual TimeSpan that was consumed (could be less than requested if insufficient stored hours).
        public TimeSpan ConsumeSavedExtraHours(int year, int month, TimeSpan amountToConsume)
        {
            if (MonthExtraTicks == null)
                MonthExtraTicks = new Dictionary<MonthSelector, long>();

            var originalRequested = amountToConsume;
            // Previous month
            MonthSelector prev = MonthSelector.Previous(month, year);
            TimeSpan prevAvailable = GetSavedMonthExtra(prev.Year, prev.Month);
            TimeSpan consumedFromPrev = Min(prevAvailable, amountToConsume);
            if (consumedFromPrev > TimeSpan.Zero)
            {
                SetSavedMonthExtra(prev.Year, prev.Month, prevAvailable - consumedFromPrev);
                amountToConsume = amountToConsume.Subtract(consumedFromPrev);
            }

            if (amountToConsume > TimeSpan.Zero)
            {
                // Current month
                TimeSpan curAvailable = GetSavedMonthExtra(year, month);
                TimeSpan consumedFromCur = Min(curAvailable, amountToConsume);
                if (consumedFromCur > TimeSpan.Zero)
                {
                    SetSavedMonthExtra(year, month, curAvailable - consumedFromCur);
                    amountToConsume = amountToConsume.Subtract(consumedFromCur);
                }
            }

            return originalRequested.Subtract(amountToConsume); // actually consumed
        }

        private static TimeSpan Min(TimeSpan a, TimeSpan b)
        {
            return a.Ticks <= b.Ticks ? a : b;
        }

        #endregion

        public class DayData
        {
            public TimeSpan StartTime;
            public TimeSpan EndTime;
            public int BreakMinutes;
            public decimal Kilometers;
            public bool isHoliday = false;
            public bool isSickDay = false;
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

        // New struct for month-level keys (serialization-friendly)
        public struct MonthSelector
        {
            public int Month;
            public int Year;

            public MonthSelector(int month, int year)
            {
                Month = month;
                Year = year;
            }

            public static MonthSelector Previous(int month, int year)
            {
                month -= 1;
                if (month == 0)
                {
                    month = 12;
                    year -= 1;
                }
                return new MonthSelector(month, year);
            }

            public override string ToString()
            {
                return $"{Month.ToString("d2")}-{Year}";
            }

            // Required for JSON parsing of dictionary keys
            public static implicit operator MonthSelector(string s)
            {
                if (string.IsNullOrWhiteSpace(s))
                    throw new ArgumentNullException(nameof(s), "Input string cannot be null or empty.");

                string[] parts = s.Split('-');
                if (parts.Length != 2)
                    throw new FormatException("Input string must be in format MM-yyyy.");

                return new MonthSelector
                {
                    Month = int.Parse(parts[0]),
                    Year = int.Parse(parts[1])
                };
            }

            // Helpful conversion from DateTime if needed
            public static implicit operator MonthSelector(DateTime date)
            {
                return new MonthSelector(date.Month, date.Year);
            }

            // For dictionary equality as key
            public override bool Equals(object obj)
            {
                if (!(obj is MonthSelector))
                    return false;
                var other = (MonthSelector)obj;
                return Month == other.Month && Year == other.Year;
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (Month * 397) ^ Year;
                }
            }
        }
    }
}
