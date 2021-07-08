using System;
using System.Collections.Generic;

namespace ex6_pangram
{
	class Program
	{
		static void Main(string[] args)
		{
			Utilities ut = new Utilities();
			string input = "The quick brown fox jumps over the lazy dog";

			if (ut.PangramOrNot(input) == true)
				Console.Write("OK\n");
			else
				Console.Write("Not OK\n");
		}
	}
}
