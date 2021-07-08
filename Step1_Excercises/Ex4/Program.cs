using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_random
{
	class Program
	{
		static void Main(string[] args)
		{
			UserInteractions userInteractions = new UserInteractions();
			string play;

			do
			{
				Console.WriteLine("\nIf you would like to play, press 1. Otherwise, press 0.\n");
				play = Console.ReadLine();
				if (int.Parse(play) != 1)
				{
					break;
				}
				userInteractions.Round();
			} while (int.Parse(play) == 1);

		}
	}
}
