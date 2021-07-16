   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_generic_class
{
	class Program
	{
		static void Main(string[] args)
		{
			List<double> arrDouble = new List<double>{ 1.1, 2.4, 5.55 };
			List<int> arrInt = new List<int>{ 1, 2, 5 };
			List<char> arrChar = new List<char>{ 'a', 'c', 'h' };

			Test<int> testInt = new Test<int>();
			Test<double> testDouble = new Test<double>();
			Test<char> testChar = new Test<char>();

			if (arrInt.Count >= 3)
			{
				Console.WriteLine("\nInt vector tests: ");
				testInt.testVector(arrInt, 0, 3, 3, 2);
			}
			else
			{
				Console.WriteLine("\nNot enough data for int tests.");
			}

			if (arrDouble.Count >= 3)
			{
				Console.WriteLine("\nDouble vector tests: ");
				testDouble.testVector(arrDouble, 0.0, 3.3, 2.5, 2);
			}
			else
			{
				Console.WriteLine("\nNot enough data for double tests.");
			}

			if (arrChar.Count >= 3)
			{
				Console.WriteLine("\nChar vector tests: ");
				testChar.testVector(arrChar, 'b', 'd', 'a', 'g');
			}
			else
			{
				Console.WriteLine("\nNot enough data for char tests.");
			}
		}
	}
}
