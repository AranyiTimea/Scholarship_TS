using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10_article
{
	class Magazine: Article
	{
		#region MagazineConstructors

		public Magazine(int articleNumber, string title, int numberOfPages, int edition, int frequency)
		{
			ArticleNumber = articleNumber;
			Title = title;
			PageNumber = numberOfPages;
			Edition = edition;
			Frequency = frequency;
		}

		#endregion


		#region MagazineProperties

		public int MagazineNumber { get; set; }
		public int Edition { get; set; }
		public int Frequency { get; set; }

		#endregion
	}
}
