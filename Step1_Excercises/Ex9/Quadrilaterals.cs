using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9_shapes
{
	abstract class Quadrilaterals : Shape
	{
		public abstract double Length { get; set; }
		public abstract double Height { get; set; }

		public override abstract double Area();
		public override abstract double Perimeter();
	}
}
