using System;

namespace TypeCasting
{
	
	public class Classone{
		public static        void othermethod(){
	Console.WriteLine("Greeting Customer!!!");
		}
		}
	
public class Program
{
	//making the new static functino inside the progarm class
	// Static Method
		static void Square(int i)
		{
			Console.WriteLine(i * i);
		}
	public void greet(){
	Console.WriteLine("hello from the same class");
	}
	public static void Main()
	{
		Square(3);
		Program insidevar = new Program();
		insidevar.greet();
		
		//to call the method of another class
		Classone.othermethod();
		
	}
}
}