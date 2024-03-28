using System;

namespace BaseKeyword
{
    public class Vehicle
    {
        public string Name { get; set; } = "No Name";
        public double Speed { get; set; } = 0;

        public Vehicle() { }
        public Vehicle(string n, double s)
        {
            Name = n; Speed = s;
        }
        public void ShowName()
        {
            Console.WriteLine("Vehicle Name: {0}", Name);
        }
    }
    public class Car : Vehicle
    {
        public int Wheels { get; set; }

        public Car() { }
        // Accessing base constructor using 'base'
        public Car(string n, double s, int w) : base(n, s)
        {
            Wheels = w;
        }
        public void ShowInfo()
        {
            // Accessing base method using 'base'
            base.ShowName();
            // Accessing base field using 'base'
            Console.WriteLine("Vehicle Speed: {0}", base.Speed);
            Console.WriteLine("Wheels Number: {0}", Wheels);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Honda", 520, 4);
            c1.ShowInfo();
            Console.WriteLine("Lab No: 5");
            Console.WriteLine("Name: Nirajan Bhattarai");
            Console.WriteLine("Roll No.: 13");
        }
    }
}
