using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTesting
{
	class Program
	{
		static void Main(string[] args)
		{
			CompareStringsMaster("A", "A");
			CompareStringsMaster("A", "B");
			CompareStringsMaster("B", "A");
			CompareStringsMaster("a", "A");
			CompareStringsMaster("Strasse", "Straße");
			CompareStringsMaster("lemon", "lime");
			CompareStringsMaster("apple", "PINEAPPLE");

			string apple1 = "Apple";

			Console.WriteLine("POOLED");
			string apple2 = "Apple";
			CheckStringEquality(apple1, apple2);

			Console.WriteLine("COPIED");
			apple2 = string.Copy(apple1);
			CheckStringEquality(apple1, apple2);

			Console.WriteLine("INTERNED");
			apple2 = string.Intern(apple1);
			CheckStringEquality(apple1, apple2);
		}

		private static void CheckStringEquality(string apple1, string apple2)
		{
			Console.WriteLine($"--- '{apple1}' and '{apple2}' ---");
			Console.WriteLine($"{apple1 == apple2} - '==' operator");
			Console.WriteLine($"{string.Equals(apple1, apple2)} - string.Equals");
			Console.WriteLine($"{string.ReferenceEquals(apple1, apple2)} - string.ReferenceEquals");
			Console.WriteLine("-----");
		}

		static void CompareStringsMaster(string a, string b)
		{
			Console.WriteLine($"-- {a} vs. {b} --");
			StringComparison[] comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));
			for (int i = 0; i < comparisons.Length; i++)
			{
				string result = "blank";
				if (string.Compare(a, b, comparisons[i]) == -1)
					result = $"{a} < {b} ({comparisons[i]})";
				else if (string.Compare(a, b, comparisons[i]) == 0)
					result = $"{a} = {b} ({comparisons[i]})";
				else if (string.Compare(a, b, comparisons[i]) == 1)
					result = $"{a} > {b} ({comparisons[i]})";
				else if (string.Compare(a, b, comparisons[i]) < -1)
					result = $"{a} < {b} by {string.Compare(a, b, comparisons[i])} ({comparisons[i]})";
				else if (string.Compare(a, b, comparisons[i]) > 1)
					result = $"{a} > {b} by {string.Compare(a, b, comparisons[i])} ({comparisons[i]})";
				Console.WriteLine(result);
			}

		}
	}
}
