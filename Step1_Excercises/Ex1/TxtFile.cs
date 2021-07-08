using System;
using System.IO;

namespace ex1_txt_file
{
	class TxtFile
	{
		private int numberOfWords;
		private string content;

		public TxtFile()
		{
			numberOfWords = 0;
			content = null;
		}

		private int CountWords(string text)
		{
			string delim = " ,.!?";
			string[] fields = text.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			return fields.Length;
		}

		public void ReadFile(string filePath)
		{
			try
			{
				var sr = new StreamReader(filePath);
				content = sr.ReadToEnd();
				numberOfWords = CountWords(content);
			}
			catch (IOException e)
			{
				numberOfWords = 0;
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
			}
		}

		public void DisplayContent()
		{
			if (content != null)
			{
				Console.WriteLine(content);
			}
			else
			{
				Console.WriteLine("The file hasn't been read.");
			}
		}

		public int GetNumberOfWords()
		{
			return numberOfWords;
		}
	}
}

