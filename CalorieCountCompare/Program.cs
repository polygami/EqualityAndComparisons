using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCountCompare
{
	class Program
	{
		static void Main(string[] args)
		{
			CalorieCount cal300 = new CalorieCount(300);
			CalorieCount cal400 = new CalorieCount(400);

			DisplayOrder(cal300, cal400);
			DisplayOrder(cal400, cal300);
			DisplayOrder(cal300, cal300);

			if (cal300 < cal400)
				Console.WriteLine("cal300 < cal400");
		}

		static void DisplayOrder<T>(T x, T y) where T : IComparable<T> //Makes sure that the type being used in the method call implement the interface and can therefore call CompareTo()
		{
			int result = x.CompareTo(y);

			if (result == 0)
				Console.WriteLine($"{x} is equal to {y}");
			else if (result > 0)
				Console.WriteLine($"{x} is greater than {y}");
			else
				Console.WriteLine($"{x} is less than {y}");
		}
	}
}
