using System;

interface IShape
{
    void Draw(); // Method signature
}

interface IColor
{
    void Fill(); // Method signature
}

class Circle : IShape, IColor
{
    public void Draw()
    {
        Console.WriteLine("Drawing circle...");
    }

    public void Fill()
    {
        Console.WriteLine("Filling circle...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        DrawAndFill(circle); // Output: Drawing circle... Filling circle...

        Console.WriteLine("Lab No: 7c");
        Console.WriteLine("Name: Nirajan Bhattarai");
        Console.WriteLine("Roll No.: 13");
    }

    static void DrawAndFill(IShape shape)
    {
        shape.Draw();
        // Check if the shape also implements the IColor interface
        if (shape is IColor coloredShape)
        {
            coloredShape.Fill();
        }
    }
}

