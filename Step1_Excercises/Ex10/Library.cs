using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10_article 
{
	class Library
	{
		#region LibraryVariables
		private List<Article> articles;
		private List<Book> books;
		private List<Magazine> magazines;
		#endregion


		#region LibraryProperties

		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public int NumberOfEmployees { get; set; }

		#endregion


		#region LibraryMethods

		public List<Article> GetAllArticles()
		{
			return articles;
		}

		public bool HasSubscribers(string title)
		{
			return true;
		}

		public List<string> GetAllAuthors()
		{
			List<string> authors = new List<string>();
			foreach (var a in articles)
			{
				authors.Add(a.Author);
			}
			return authors;
		}

		public void DisplayAllBooks()
		{
			foreach (var book in books)
			{
				Console.WriteLine("{0} by {1}", book.Title, book.Author);
			}
		}

		public void DisplayAllMagazine()
		{
			foreach (var magazine in magazines)
			{
				Console.WriteLine("{0} by {1}", magazine.Title, magazine.Author);
			}
		}

		#endregion
	}
}
