using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ex7_number_actions
{
	class InputValidation
	{
		private static Regex regex = new Regex("^[0-9]{4}$", RegexOptions.Compiled);

		public bool CheckNumber(string number)
		{
			return regex.IsMatch(number);
		}
	}
}
