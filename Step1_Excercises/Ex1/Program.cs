using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_txt_file
{
	class Program
	{
		static void Main(string[] args)
		{
			TxtFile txtFile = new TxtFile();
			txtFile.ReadFile("test.txt");
			txtFile.DisplayContent();
			Console.WriteLine("The file contains {0} words.", txtFile.GetNumberOfWords());
		}
	}
}
