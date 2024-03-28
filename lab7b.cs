using System;

// Interface for shapes
interface IShape
{
    void Draw();
}

// Concrete implementation of Circle
class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing circle...");
    }
}

// Concrete implementation of Square
class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing square...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects of different shapes
        IShape circles = new Circle();
        IShape squares = new Square();

        // Drawing shapes without knowing the specific implementation
        DrawShape(circles); // Output: Drawing circle...
        DrawShape(squares); // Output: Drawing square...
        Console.WriteLine("Lab No: 7b");
        Console.WriteLine("Name: Nirajan Bhattarai");
        Console.WriteLine("Roll No.: 13");
    }

    // Method to draw any shape implementing IShape
    static void DrawShape(IShape shape)
    {
        shape.Draw();
    }
}
