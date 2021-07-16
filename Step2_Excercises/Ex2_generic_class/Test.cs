using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_generic_class
{
	class Test<T> where T:struct
	{
		public void testVector(List<T> arr, T toAdd1, T toAdd2, T checkContains, T greaterThan)
		{
			Vector<T> vect = new Vector<T>(arr);
			vect.Add(toAdd1); vect.Add(toAdd2);
			vect.Show();
			Console.WriteLine("The minimum in the vector is {0}, the maximum is {1}.", vect.Min(), vect.Max());
			Console.WriteLine("The vector contains the value {0}: {1}", checkContains, vect.Contains(checkContains));
			vect.Show();
			Console.WriteLine("The element at index 0 has been removed. It had the value {0}", vect.Remove(0));
			vect.Show();
			vect.Swap(1, 3);
			Console.WriteLine("The elements at index 1 and 3 have been swapped.");
			vect.Show();
			Console.WriteLine("There are {0} elements greater than 2.", vect.CountGreaterThan(greaterThan));
		}
	}
}
