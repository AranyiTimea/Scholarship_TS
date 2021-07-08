using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_months_v3_list
{
	class Month
	{
		private readonly string[] monthsSongs = { "January Gloom - All Time Law", 
			"February Winds - Billy Talent", "Winds Of March - Journey", 
			"April Rain - Delain", "The May Song - The Gathering", 
			"June's Foreign Spell - Spoon", "July Tree - Nina Simone", 
			"Stuck in the August Rain - Jethro Tull", "Wake me up when September ends - Green Day",
			"October & April - The Rasmus feat. Anette Olzon",
			"November Rain - Guns N'Roses", "Once Upon a December - Deana Carter"
		};

		public string[] MonthsSongs => monthsSongs;

		private enum MonthsEnum
		{
			January,
			February,
			March,
			April,
			May,
			June,
			July,
			August,
			September,
			October,
			November,
			December,
		}

		public int stringToInt(string month)
		{
			MonthsEnum monthType;
			Enum.TryParse(month, out monthType);
			return (int)monthType;
		}
	}
}
