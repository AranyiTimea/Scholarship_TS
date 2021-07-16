using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_working_days
{
	class Utilities
	{
		public TimeSpan NumberOfDays(DateTime pastDate, DateTime presentDate)
		{
			return (presentDate - pastDate);
		}

        public int WeekendDays(DateTime pastDate, DateTime presentDate, TimeSpan span)
        {
            int workDays = span.Days;
            int fullWeeks = workDays / 7;
            int weekendDays = fullWeeks * 2;

            if (workDays % 7 != 0)
            {
                if (pastDate.DayOfWeek <= DayOfWeek.Saturday)
                {
                    if (presentDate.DayOfWeek >= DayOfWeek.Sunday) weekendDays += 2;
                    else if (presentDate.DayOfWeek >= DayOfWeek.Saturday) weekendDays += 1;
                }
                else if (pastDate.DayOfWeek <= DayOfWeek.Sunday && presentDate.DayOfWeek >= DayOfWeek.Sunday) weekendDays += 1;
            }

            return weekendDays;
        }

        public int Holidays(DateTime pastDate, DateTime presentDate, params DateTime[] holidays)
        {
            int legalHolidays = 0;

            foreach (var holiday in holidays)
            {
                DateTime h = holiday.Date;
				if (pastDate <= h && h <= presentDate)
					legalHolidays++;
            }

            return legalHolidays;
        }

		public int WorkDays(DateTime pastDate, DateTime presentDate, params DateTime[] holidays)
		{
            TimeSpan span = NumberOfDays(pastDate, presentDate);
            int workDays = span.Days;

            workDays -= WeekendDays(pastDate, presentDate, span);
            workDays -= Holidays(pastDate, presentDate, holidays);

            return workDays;
        }

		public bool CheckDates(DateTime pastDate, DateTime presentDate)
		{
			return pastDate < presentDate;
		}
	}
}
