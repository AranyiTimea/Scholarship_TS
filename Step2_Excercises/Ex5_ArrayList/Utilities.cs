using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_ArrayList
{
	class Utilities
	{
		public ArrayList RemoveNotNumericTypes(ArrayList arr)
		{
			ArrayList newArr = new ArrayList();
			for (int i = 0; i < arr.Count; i++)
			{
				if (IsNumericType(arr[i]))
				{
					newArr.Add(arr[i]);
				}
			}
			return newArr;
		}

		public bool IsNumericType(object obj)
		{
			switch (Type.GetTypeCode(obj.GetType()))
			{
				case TypeCode.Byte:
					return true;
				case TypeCode.SByte:
					return true;
				case TypeCode.UInt16:
					return true;
				case TypeCode.UInt32:
					return true;
				case TypeCode.UInt64:
					return true;
				case TypeCode.Int16:
					return true;
				case TypeCode.Int32:
					return true;
				case TypeCode.Int64:
					return true;
				case TypeCode.Decimal:
					return true;
				case TypeCode.Double:
					return true;
				case TypeCode.Single:
					return true;
				default:
					return false;
			}
		}

		public void ShowArrayList(ArrayList arr)
		{
			foreach (object obj in arr)
			{
				Console.WriteLine(obj);
			}
		}

		public double Sum(ArrayList arr)
		{
			double suma = 0;
			foreach (object obj in arr)
			{
				suma += (double)obj;
			}

			return suma;
		}
	}

}
