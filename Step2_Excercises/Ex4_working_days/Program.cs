using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_working_days
{
	class Program
	{
		static void Main(string[] args)
		{
			Utilities ut = new Utilities();
			DateTime start = new DateTime(2020, 07, 10);
			DateTime end = new DateTime(2021, 07, 11);

			if (ut.CheckDates(start, end))
			{
				Console.WriteLine("The number of workdays between {0} and {1} is {2}.", start, end, ut.WorkDays(start, end, new DateTime(1980, 5, 5), new DateTime(2020, 12, 25), new DateTime(2021, 5, 5), new DateTime(1999, 1, 1)));
			}
			else
			{
				Console.WriteLine("The starting date can't be after the end date.");
			}
		}
	}
}
