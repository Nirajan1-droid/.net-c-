using System;

namespace TypeCasting
{
	
	
public class Program
{
	int value;
	//making the new static functino inside the progarm class
	// Static Method
		static void Square(int i)
		{
			Console.WriteLine(i * i);
		}
	//this modify method is both static and void.
	static void modify(Program obj){
	obj.value *= 2;
		Console.WriteLine("Modified value = {0}", obj.value);
	}
	public void greet(){
	Console.WriteLine("hello from the same class");
	} 
static void Main(string[] args)
		{
	int  i  = 5;
	
			Program obj = new Program();
			obj.value =2;
	Square(i);
	modify(obj);//object ref is passing to the static function/method of the class.
	
	
			
		}
}
}