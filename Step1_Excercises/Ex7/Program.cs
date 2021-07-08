 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7_number_actions
{
	class Program
	{
		static void Main(string[] args)
		{
			InputValidation iv = new InputValidation();
			Actions actions = new Actions();
			string number;
			number = Console.ReadLine();

			if (iv.CheckNumber(number))
			{
				Console.WriteLine("The sum of the digits is {0}.", actions.Sum(number));
				actions.PrintReversed(number);
				actions.ExchangeTest(number);
			}

			else
			{
				Console.WriteLine("Incorrect input.");
			}
		}
	}
}
