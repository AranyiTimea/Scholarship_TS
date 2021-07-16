using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unitTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Check_Sum_Correct()
		{
			// Arrange
			double expectedValue = 101;
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

			// Act
			dataList = ut.RemoveNotNumericTypes(dataList);
			double actualValue = ut.Sum(dataList);

			// Assert
			Assert.AreEqual(expectedValue, actualValue);
		}

		[TestMethod]
		public void Check_Sum_Incorrect()
		{
			// Arrange
			double notExpectedValue = 121;
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

			// Act
			dataList = ut.RemoveNotNumericTypes(dataList);
			double actualValue = ut.Sum(dataList);

			// Assert
			Assert.AreNotEqual(notExpectedValue, actualValue);
		}
	}
}
