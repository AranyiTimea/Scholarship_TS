using System;

namespace ex4_random
{
	class Game
	{
		#region GameVariables

		private int low;
		private int high;
		private int toGuess;

		#endregion


		#region GameConstructors

		public Game(int low, int high)
		{
			this.low = low;
			this.high = high;
			toGuess = GenerateNumber(low, high);
		}

		#endregion


		#region GameProperties

		public int Low { get => low; set => low = value; }
		public int High { get => high; set => high = value; }

		#endregion


		#region GameMethods

		private int GenerateNumber(int lowest, int highest)
		{
			Random rnd = new Random();
			return rnd.Next(lowest, highest + 1);
		}

		public int GetToGuess()
		{
			return toGuess;
		}

		#endregion
	}
}
