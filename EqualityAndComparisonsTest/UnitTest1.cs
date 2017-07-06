using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace EqualityAndComparisonsTest
{

	[TestClass]
	public class UnitTest1
	{
		/*[TestMethod]
		public void AreIntegersEqual()
		{
			int threeA = 3;
			int threeB = 3;
			bool areIntsEqual = (threeA == threeB);
			Assert.IsTrue(areIntsEqual);
		}
		[TestMethod]
		public void AreIntegersAsObjectsEqual()
		{
			int threeA = 3;
			int threeB = 3;
			bool areIntsEqual = ((object)threeA == (object)threeB); //This is comparing references, not values
			Assert.IsTrue(areIntsEqual);
		}
		[TestMethod]
		public void AreIntegersAsInterfacesEqual()
		{
			int threeA = 3;
			int threeB = 3;
			bool areIntsEqual = ((IComparable<int>)threeA == (IComparable<int>)threeB);
			Assert.IsTrue(areIntsEqual);
		}
		[TestMethod]
		public void AreStringsEqual()
		{
			string textA = "Hello World";
			string textB = "Hello World";
			bool areStringsEqual = (textA == textB); //This is comparing references, not values
			Assert.IsTrue(areStringsEqual);
		}
		[TestMethod]
		public void AreDifferentCaseStringsEqual()
		{
			string textA = "hello world";
			string textB = "Hello World";
			bool areStringsEqual = (textA == textB);
			Assert.IsTrue(areStringsEqual);
		}
		[TestMethod]
		public void AreSameValueFloatsEqual()
		{
			float floatA = 6.000000000f;
			float floatB = 6.000000000f;
			bool areStringsEqual = (floatA == floatB);
			Assert.IsTrue(areStringsEqual);
		}
		[TestMethod]
		public void AreDifferentValueFloatsEqual()
		{
			float floatA = 6.000000000f;
			float floatB = 6.000000001f;
			bool areStringsEqual = (floatA == floatB);
			Assert.IsTrue(areStringsEqual);
		}
		[TestMethod]
		public void AreCalculatedFloatsEqual()
		{
			float floatA = 6.0f;            //floatA = 6.0f		The problem with equality
			float floatB = 5.05f + 0.095f;  //floatB ≈ 6.0f		and floating point numbers.
			bool areStringsEqual = (floatA == floatB);
			Assert.IsTrue(areStringsEqual);
		}*/

		//3. The Equality Operator
		//i. ints - Value Equality
		[TestMethod]
		public void AreIntsEqualOperator()
		{
			int threeA = 3;
			int threeB = 3;
			Assert.IsTrue(threeA == threeB);
		}
		[TestMethod]
		public void AreIntsEqualMethod()
		{
			int threeA = 3;
			int threeB = 3;
			Assert.IsTrue(threeA.Equals(threeB));
		}
		//ii. buttons - Reference Equality
		[TestMethod]
		public void AreButtonsEqualOperator()
		{
			Button button1 = new Button();
			button1.Text = "Click me now!";

			Button button2 = new Button();
			button2.Text = "Click me now!";

			Assert.IsTrue(button1 == button2);
		}
		[TestMethod]
		public void AreButtonsEqualMethod()
		{
			Button button1 = new Button();
			button1.Text = "Click me now!";

			Button button2 = new Button();
			button2.Text = "Click me now!";
			Assert.IsTrue(button1.Equals(button2));
		}

		//iii. strings - Although different reference, evaluates value equality (overloaded equality operator)
		[TestMethod]
		public void AreStringsEqualOperator()
		{
			string str1 = "Hello World!";
			string str2 = string.Copy(str1);

			Assert.IsTrue(str1 == str2);
		}
		[TestMethod]
		public void AreStringsEqualMethod()
		{
			string str1 = "Hello World!";
			string str2 = string.Copy(str1);

			Assert.IsTrue(str1.Equals(str2));
		}

		//v. tuples - As they're value types, they should return false, however the Equals() method has been overloaded to check value equality. This hasn't been done for the operator!!
		[TestMethod]
		public void AreTuplesEqualReference()
		{
			Tuple<int, int> tuple1 = Tuple.Create(1, 3);
			Tuple<int, int> tuple2 = Tuple.Create(1, 3);

			Assert.IsTrue(ReferenceEquals(tuple1, tuple2));
		}
		[TestMethod]
		public void AreTuplesEqualOperator()
		{
			Tuple<int, int> tuple1 = Tuple.Create(1, 3);
			Tuple<int, int> tuple2 = Tuple.Create(1, 3);
			
			Assert.IsTrue(tuple1 == tuple2);
		}
		[TestMethod]
		public void AreTuplesEqualMethod()
		{
			Tuple<int, int> tuple1 = Tuple.Create(1, 3);
			Tuple<int, int> tuple2 = Tuple.Create(1, 3);
			
			Assert.IsTrue(tuple1.Equals(tuple2));
		}

		//vi - inheritance and the '==' operator - '==' doesn't always work, because it is static and can't be virtual, so when calling a method it will take the Type of the variable and its method rather than its overloaded child methods
		[TestMethod]
		public void AreObjectsEqualStringMethod()
		{
			object str1 = "apple";
			object str2 = string.Copy((string)str1);

			Assert.IsTrue(str1.Equals(str2));
		}
		[TestMethod]
		public void AreObjectsEqualOperator()
		{
			object str1 = "apple";
			object str2 = string.Copy((string)str1);
			
			Assert.IsTrue(str1 == str2); //'==' is static, so it will use the object version of the operator, rather than the string overloaded method.
		}
		[TestMethod]
		public void AreObjectsEqualObjectMethod()
		{
			object str1 = "apple";
			object str2 = string.Copy((string)str1);
			
			Assert.IsTrue(object.Equals(str1, str2));
		}

	}
}
