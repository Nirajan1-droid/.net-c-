using System;

// Structure (struct)
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

// Enumeration (enum)
public enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

// Partial class
public partial class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public partial class Person
{
    public void DisplayFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using Structure (struct)
        Point point = new Point { X = 10, Y = 20 };
        Console.WriteLine($"Point: ({point.X}, {point.Y})");

        // Using Enumeration (enum)
        DayOfWeek today = DayOfWeek.Wednesday;
        Console.WriteLine($"Today is: {today}");

        // Using Partial Class
        Person person = new Person { FirstName = "Nirajan", LastName = "Bhattarai" };
        person.DisplayFullName(); // Output: Full Name: John Doe
        Console.WriteLine("Lab No: 8");
        Console.WriteLine("Name: Nirajan Bhattarai");
        Console.WriteLine("Roll No.: 13");

    }
}


 