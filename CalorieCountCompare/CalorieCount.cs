using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCountCompare
{
	public struct CalorieCount : IEquatable<CalorieCount>, IComparable<CalorieCount>, IComparable
	{


		private float _value;
		public float Value { get { return _value;  } }

		public CalorieCount (float value)
		{
			this._value = value;
		}

		public override string ToString()
		{
			return _value + " Kcal";
		}

		//Implementing IEquatable<T>

		public bool Equals(CalorieCount other)
		{
			return this._value == other._value;
		}

		public override bool Equals(object obj)
		{
			if (obj is CalorieCount)
				return Equals((CalorieCount)obj);
			else
				return false;
		}

		public static bool operator ==(CalorieCount lhs, CalorieCount rhs)
		{
			return lhs.Equals(rhs);
		}

		public static bool operator !=(CalorieCount lhs, CalorieCount rhs)
		{
			return !lhs.Equals(rhs);
		}

		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}

		//Implementing IComparable<T>

		public int CompareTo(CalorieCount other)
		{
			return this._value.CompareTo(other._value);
		}

		public static bool operator <(CalorieCount lhs, CalorieCount rhs)
		{
			return rhs._value < lhs._value;
		}

		public static bool operator <=(CalorieCount lhs, CalorieCount rhs)
		{
			return rhs._value <= lhs._value;
		}

		public static bool operator >(CalorieCount lhs, CalorieCount rhs)
		{
			return rhs._value > lhs._value;
		}

		public static bool operator >=(CalorieCount lhs, CalorieCount rhs)
		{
			return rhs._value >= lhs._value;
		}

		//Implementing IComparable

		public int CompareTo(object obj)
		{
			if (obj == null)
				throw new ArgumentNullException("obj");
			if (!(obj is CalorieCount))
				throw new ArgumentException("Expected CalorieCount instance", "obj");
			return CompareTo((CalorieCount)obj);
		}
	}
}
