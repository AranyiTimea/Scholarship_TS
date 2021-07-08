using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_months_v3_list
{
	

	class Program
	{
		static void Main(string[] args)
		{
			int newSong;
			Utilities ut = new Utilities();

			do
			{
				Console.WriteLine("\nWould you like to get a song suggestion for a month of your choice? Press 1 if yes, 0 otherwise.");
				newSong = int.Parse(Console.ReadLine());
				if (newSong == 0)
				{
					break;
				}
				ut.ShowRecommandation();
			} while (newSong == 1);
		}
	}
}
