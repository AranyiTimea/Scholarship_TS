using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_ArrayList
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayList dataList = new ArrayList();
			dataList.Add(2);
			dataList.Add("Today!");
			dataList.Add("13.5");
			dataList.Add("red");
			dataList.Add(99);
			dataList.Add("app");
			dataList.Add(true);
			dataList.Add("6.5");
			dataList.Add("Soup");

			Utilities ut = new Utilities();

			Console.WriteLine("Before removing not numeric types:");
			ut.ShowArrayList(dataList);
			ut.RemoveNotNumericTypes(dataList);
			Console.WriteLine("After removing not numeric types:");
			ut.ShowArrayList(ut.RemoveNotNumericTypes(dataList));
		}
	}
}
