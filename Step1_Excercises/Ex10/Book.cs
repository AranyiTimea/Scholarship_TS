using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10_article
{
	class Book: Article
	{
		#region BookConstructors

		public Book(int articleNumber, string title, string author, string publisher, int numberOfPages, int year, string coverType)
		{
			ArticleNumber = articleNumber;
			Title = title;
			Author = author;
			Publisher = publisher;
			PageNumber = numberOfPages;
			Year = year;
			CoverType = coverType;
		}

		public Book(Book book)
		{
			this.ArticleNumber = book.ArticleNumber;
			this.Title = book.Title;
			this.Author = book.Author;
			this.Publisher = book.Publisher;
			this.PageNumber = book.PageNumber;
			this.Year = book.Year;
			this.CoverType = book.CoverType;
		}

		#endregion


		#region BookProperties

		public string Publisher { get; set; }
		public int Year { get; set; }
		public string CoverType { get; set; }

		#endregion
	}
}
