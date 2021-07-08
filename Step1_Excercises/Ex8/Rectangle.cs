using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_rectangle
{
	class Rectangle
	{
		#region RectangleVariables
		private double width;
		private double length;
		#endregion

		#region RectangleProperties
		public double Width { get => width; set => width = value; }
		public double Length { get => length; set => length = value; }
		#endregion


		#region RectangleMethods

		public double Area()
		{
			return width * length;
		}

		public double Perimeter()
		{
			return (2 * width) + (2 * length);
		}

		#endregion
	}
}
