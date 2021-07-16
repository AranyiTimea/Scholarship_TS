using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_number_of_days
{
	class Utilities
	{
		public int NumberOfDays(DateTime pastDate, DateTime presentDate)
		{
			return (presentDate - pastDate).Days;
		}
	}

	class Program
	{
		public static void Main(string[] args)
		{
			Utilities ut = new Utilities();
			DateTime past = new DateTime(2021, 07, 10);
			DateTime present = DateTime.Today;
			Console.WriteLine("The number of days between {0} and {1} is {2}.", past, present, ut.NumberOfDays(past, present));
		}
	}
}
