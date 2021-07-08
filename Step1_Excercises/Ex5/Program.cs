using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_grades
{
	class Program
	{
		static void Main(string[] args)
		{
			Grades grades = new Grades();
			Console.WriteLine("10 is {0}.\n", grades.Category(10));
			Console.WriteLine("6 is {0}.\n", grades.Category(6));
			Console.WriteLine("9 is {0}.\n", grades.Category(9));
			Console.WriteLine("3 is {0}.\n", grades.Category(3));
		}
	}
}
