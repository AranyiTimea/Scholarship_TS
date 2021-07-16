using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_generic_method
{
	class Utility
	{
		internal void Write<T>(ref T a)
		{
			Console.WriteLine(a);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Utility ut = new Utility();
			int x = 2;
			string str = "Test";
			char c = '%';
			double y = 2.222;
			Console.WriteLine("\nInt: ");
			ut.Write(ref x);
			Console.WriteLine("\nString: ");
			ut.Write(ref str);
			Console.WriteLine("\nChar: ");
			ut.Write(ref c);
			Console.WriteLine("\nDouble: ");
			ut.Write(ref y);
		}
	}
}
