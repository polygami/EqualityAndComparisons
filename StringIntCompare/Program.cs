using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIntCompare
{
	class Program
	{
		static void Main(string[] args)
		{
			string apple = "apple";
			string pear = "pear";

			Console.WriteLine(apple.CompareTo(pear));
			Console.WriteLine(pear.CompareTo(apple));
			Console.WriteLine(apple.CompareTo(apple));

			DisplayOrder(apple, pear);
			DisplayOrder(pear, apple);
			DisplayOrder(apple, apple);

			DisplayOrder(1, 2); //also works for int because the type implements IComaparable<T>
			DisplayOrder(2, 1);
			DisplayOrder(1, 1);
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
