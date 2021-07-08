using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_months_v3_list
{
	class Utilities
	{
		public bool checkInput(string input)
		{
			string[] months = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
			// Array.Find daca nu gaseste elementul cautat, returneaza valoarea default pt tipul dat; in cazul acesta null -> string este tip referinta
			if (Array.Find(months, element => element == input.ToLower()) != null)
				return true;
			return false;
		}

		public void ShowRecommandation()
		{
			Month mon = new Month();
			string month;
			Console.WriteLine("Enter a month: ");
			try
			{
				month = Console.ReadLine();
				if (checkInput(month))
				{
					Console.WriteLine("\nThe song for this month is: ");
					month = char.ToUpper(month[0]) + month.Substring(1);
					Console.WriteLine(mon.MonthsSongs[mon.stringToInt(month)]);
				}
				else
				{
					Console.WriteLine("\nIncorrect input!");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
