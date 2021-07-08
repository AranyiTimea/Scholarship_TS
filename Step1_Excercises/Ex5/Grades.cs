using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_grades
{
	class Grades
	{
		public string Category(int grade)
		{
			switch (grade)
			{
				case int n when (n >= 10):
					return "Excellent";

				case int n when (n < 10 && n >= 8):
					return "Very Good";

				case int n when (n < 8 && n >= 5):
					return "Good";

				case int n when (n < 5):
					return "Bad";
			}
			return "Incorrect grade";
		}
	}
}
