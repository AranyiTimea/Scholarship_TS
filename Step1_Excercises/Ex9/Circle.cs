using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9_shapes
{
	class Circle : Shape
	{
		private const double Pi = 3.1415;
		private double radius;

		public double Radius { get => radius; set => radius = value; }

		public override double Area()
		{
			return Pi * radius * radius;
		}
		public override double Perimeter()
		{
			return 2 * Pi * radius;
		}

		public double Diameter()
		{
			return 2 * radius;
		}
	}
}
