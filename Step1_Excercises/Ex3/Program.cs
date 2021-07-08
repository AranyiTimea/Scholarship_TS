using System;

namespace ex3_sum
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculations calc = new Calculations();
			Console.WriteLine("10 + 5 = {0}.", calc.Sum(10, 5));
			Console.WriteLine("9.55 + 1 = {0}.", calc.Sum(9.55, 1.0));
			Console.WriteLine("9.5 + 10 + 1 + 4 = {0}.", calc.Sum("9.5", "10", "1.0", "4"));
		}
	}
}
