using System;

namespace ex3_sum
{
	class Calculations
	{
		public int Sum(int number1, int number2)
		{
			return number1 + number2;
		}

		public double Sum(double number1, double number2)
		{
			return number1 + number2;
		}

		public double Sum(params string[] args)
		{
			double sum = 0;
			foreach (var number in args)
			{
				sum += Double.Parse(number, System.Globalization.CultureInfo.InvariantCulture);
			}
			return sum;
		}
	}
}
