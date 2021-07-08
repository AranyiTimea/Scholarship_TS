using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_random
{
	class UserInteractions
	{
		public int SetLow()
		{
			Console.WriteLine("\nLowest integer to be generated: ");
			return int.Parse(Console.ReadLine());
		}

		public int SetHigh()
		{
			Console.WriteLine("\nHighest integer to be generated: ");
			return int.Parse(Console.ReadLine());
		}

		public void Round()
		{
			int guessedValue, hi, lo;
			hi = SetHigh();
			lo = SetLow();
			Game game = new Game(lo, hi);

			do
			{
				Console.WriteLine("\nYour guess, between {0} and {1}: ", game.Low, game.High);
				guessedValue = int.Parse(Console.ReadLine());
				if (guessedValue != game.GetToGuess())
				{
					Console.WriteLine("\nYour guess is wrong. Try again.");
				}

			} while (guessedValue != game.GetToGuess());

			Console.WriteLine("\nCongratulations! You guessed right!");
		}
	}
}
