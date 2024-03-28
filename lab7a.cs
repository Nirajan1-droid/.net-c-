using System;

abstract class Shape
{
    public abstract void Draw(); // Abstract method
    public void Display()
    {
        Console.WriteLine("Displaying shape...");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing circle...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.Display(); // Output: Displaying shape...
        circle.Draw();    // Output: Drawing circle...
        Console.WriteLine("Lab No: 7a");
        Console.WriteLine("Name: Nirajan Bhattarai");
        Console.WriteLine("Roll No.: 13");
    }
}
