using System;

namespace optional_1_number_of_letters
{
	class Program
	{
		static void Main(string[] args)
		{
			Utilities ut = new Utilities();
			string str = "aaanna issss attt ssschhoooool";
			if (ut.IsValid(str))
			{
				Console.WriteLine(ut.NumberOfAppearance(str));
			}
			else
			{
				Console.WriteLine("Wrong input");
			}
		}
	}
}
