using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10_article
{
	class Article
	{
		#region ArticleProperties

		public int ArticleNumber{ get; set; }
		public string Title { get; set; }
		public int PageNumber { get; set; }
		public bool IsAvailable { get; set; }
		public string Author { get; set; }

		#endregion


		#region ArticleMethods

		public void DisplayDetails()
		{
			Console.WriteLine("Title: {0}", Title);
			Console.WriteLine("Author: {0}", Author);
			Console.WriteLine("Article Number: {0}", ArticleNumber);
			Console.WriteLine("Number of pages: {0}", PageNumber);
			Console.WriteLine("Is available: {0}", IsAvailable);
		}
		public void Read(string title)
		{
		}

		#endregion
	}
}
