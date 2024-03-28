
 using System;

namespace DynamicPolymorphism
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Shape Drawing ");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle Drawing ");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle Drawing ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            Circle c1 = new Circle();
            Rectangle r1 = new Rectangle();

            // Dynamic Polymorphism 
            s1.Draw();
            c1.Draw();
            r1.Draw();
            Console.WriteLine("Lab No: 6b");
            Console.WriteLine("Name: Nirajan Bhattarai");
            Console.WriteLine("Roll No.: 13");
        }
    }
}
