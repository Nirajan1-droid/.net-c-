using System;

namespace HidingandOverriding
{
    public class Vehicle
    {
        public string Name { get; set; }
        // Method to be Overridden
        public virtual void Greet()
        {
            Console.WriteLine("Hello Vehicle Driver!");
        }
        // Method to be Hidden
        public void ShowInfo()
        {
            Console.WriteLine("Vehicle Name is: {0}", Name);
        }
    }
    public class Car : Vehicle
    {
        public int Wheels { get; set; }
        // Overridden method still has relation with base method
        public override void Greet()
        {
            Console.WriteLine("Hello Car Driver!");
        }
        // New method with no relation with 'ShowInfo()' of base class
        public new void ShowInfo()
        {
            Console.WriteLine("Car Name is: {0}", Name);
            Console.WriteLine("Wheels Number: {0}", Wheels);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();
            v1.Name = "Toyota";
            v1.Greet();
            v1.ShowInfo();
            Console.WriteLine();

            Car c1 = new Car();
            c1.Name = "BMW";
            c1.Wheels = 4;
            c1.Greet();                     // Overriden Method
            c1.ShowInfo();                  // New Method
            Console.WriteLine();

            Console.WriteLine("Lab No: 6a");
Console.WriteLine("Name: Nirajan Bhattarai");
Console.WriteLine("Roll No.: 13");
        }
    }
}


