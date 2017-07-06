using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEquals
{
	class Program
	{
		static void Main(string[] args)
		{
			Food banana = new Food("banana");
			Food banana2 = new Food("banana");
			Food chocolate = new Food("chocolate");

			Console.WriteLine(banana.Equals(null));

			int three = 3;
			int threeAgain = 3;
			int four = 4;

			Console.WriteLine(three.Equals(threeAgain));
			Console.WriteLine(three.Equals(four));
		}
	}
}
