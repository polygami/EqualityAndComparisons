using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEqualityAndComparisons
{
	class Program
	{
		static void Main(string[] args)
		{
			PrintAll();
		}

		static public void PrintAll()
		{
			for (int i = 0; i < char.MaxValue; i++)
			{
				char foo = (char)i;
				string bar = foo.ToString();
				if (bar == "?")
				{
					Console.WriteLine($"{i} = {bar}");
				}
			}
		}
	}
}
