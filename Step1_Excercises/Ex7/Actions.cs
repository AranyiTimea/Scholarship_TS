using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7_number_actions
{
	class Actions
	{
		public int Sum (string number)
		{
			int sum = 0;
			char[] digits = number.ToCharArray();

			foreach (char digit in digits)
			{
				sum = sum + (digit- '0');
			}

			return sum;
		}

		public string Reverse(string number)
		{
			char[] digits = number.ToCharArray();
			Array.Reverse(digits);
			return new string(digits);
		}

		public void PrintReversed(string number)
		{
			Console.WriteLine("The reversed number is {0}.", Reverse(number));
		}

		public string ExchangeTwoDigits(string number, int pos1, int pos2)
		{
			char[] digits = number.ToCharArray();

			char aux = digits[pos1];
			digits[pos1] = digits[pos2];
			digits[pos2] = aux;

			return new string(digits);
		}

		public void ExchangeTest(string number)
		{
			Console.WriteLine("The first and last digits exchanged: {0}.", ExchangeTwoDigits(number, 0, number.Length - 1));
			Console.WriteLine("The second and third digits exchanged: {0}.", ExchangeTwoDigits(number, 1, 2));
		}
	}
}
