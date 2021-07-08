using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_pangram
{
	class Utilities
	{
		public bool PangramOrNot(string input)
		{
			input.ToLower();
			Dictionary<char, bool> appearence = new Dictionary<char, bool>();

			for (char c = 'a'; c <= 'z'; c++)
				appearence.Add(c, false);

			foreach (char c in input)
				appearence[c] = true;

			foreach (var c in appearence)
				if (!c.Value)
					return false;
			return true;
		}
	}
}
