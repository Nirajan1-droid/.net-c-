using System;
using System.Linq; // Import LINQ namespace

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        // LINQ query to filter even numbers
        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        // Displaying the even numbers
        Console.WriteLine("Even numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Lab No:13");
        Console.WriteLine("Name: Nirajan Bhattarai");
        Console.WriteLine("Roll No.: 13");
    }
}

  

