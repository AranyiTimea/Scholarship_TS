using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace optional_1_number_of_letters
{
	class Utilities
	{
		private static bool IsLetter(char character)
		{
			return Regex.IsMatch(character.ToString(), @"^[a-zA-Z]$");
		}

		public bool IsValid(string str)
		{
			return str != null;
		}

		public string NumberOfAppearance(string str)
		{
			char prev = str[0];
			int appeared = 1;
			string newStr = str[0].ToString();
			foreach (var c in str)
			{
				Console.WriteLine(c);
				if (IsLetter(c))
				{
					if (c == prev)
					{
						appeared++;
					}
					else if (c != prev)
					{
						Console.WriteLine("c = {0}", c);
						newStr.Append((char)appeared);
						newStr.Append(c);
						Console.WriteLine("newStr = {0}",newStr);
						appeared = 1;
					}
				}
				else
				{
					newStr.Append(c);
				}
				prev = c;
			}
			
			return newStr;
		}
	}
}
