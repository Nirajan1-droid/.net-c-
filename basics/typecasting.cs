using System;

namespace TypeCasting
{
	// 'Class' is also a type
	public class MyClass
	{
		public string name;
	}

	public class Program
	{
		static void Main(string[] args)
		{
			// Implicit Type Conversion
			int n1 = 5;
			double n2 = n1;					// Int -> Double
			Console.WriteLine(n2);

			// Explicit Type Conversion
			double n3 = 10.53d;
			int n4 = (int) n3;				// Double -> Int
			Console.WriteLine(n4);

			// Converting to custom Class type
			object myObj1 = new MyClass();//object is the datatype in the cs
			MyClass myObj2 = (MyClass) myObj1;//we are converting the object tpye to the class type
			myObj2.name = "nirajan";
			Console.WriteLine("Object to Class, Name: {0}", myObj2.name);

		 
		}
	}
}