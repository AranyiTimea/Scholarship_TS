using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_generic_class
{
	class Vector<T> where T:struct
	{
		private List<T> arr;

		public Vector(List<T> array)
		{
			arr = array;
		}

		public void Add(T element)
		{
			arr.Add(element);
		}

		public T Remove(int index)
		{
			T removed = arr[index];
			arr.RemoveAt(index);

			return removed;
		}

		public bool Contains(T element) 
		{
			for (int i = 0; i < arr.Count; i++)
			{
				// solution from: https://stackoverflow.com/questions/14020486/operator-overloading-with-generics
				if ((dynamic)arr[i] == (dynamic)element)
				{
					return true;
				}
			}
			return false;
		}

		public void Swap(int index1, int index2)
		{
			var aux = arr[index1];
			arr[index1] = arr[index2];
			arr[index2] = aux;
		}

		public int CountGreaterThan(T element)
		{
			int count = 0;
			for (int i = 0; i < arr.Count; i++)
			{
				if ((dynamic)arr[i] > (dynamic)element)
				{
					count++;
				}
			}
			return count;
		}

		public T Max()
		{
			return arr.Max();
		}

		public T Min()
		{
			return arr.Min();
		}

		public void Show()
		{
			for (int i = 0; i < arr.Count; i++)
			{
				Console.WriteLine(arr[i]);
			}
		}
	}
}
