using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9_shapes
{
	class Square : Quadrilaterals
	{
		private double length;
		private double height;

		public override double Length { get => length; set => length = value; }
		public override double Height { get => height; set => height = value; }

		public override double Area()
		{
			return length * height;
		}
		public override double Perimeter()
		{
			return 2 * length + 2 * height;
		}
	}
}
