using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Lambda expression demonstration (a)
        Func<int, int, int> add = (x, y) => x + y; // Lambda expression for addition
        Console.WriteLine("Result of addition using Lambda expression: " + add(3, 5)); // Output: Result of addition using Lambda expression: 8

        // LINQ with Lambda expression (b)
        int[] numbers = { 1, 2, 3, 4, 5 };

        // LINQ query with Lambda expression to filter even numbers
        var evenNumbers = numbers.Where(num => num % 2 == 0);

        // Displaying the even numbers
        Console.WriteLine("\nEven numbers using LINQ with Lambda expression:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }


        Console.WriteLine("Lab No:14");
        Console.WriteLine("Name: Nirajan Bhattarai");
        Console.WriteLine("Roll No.: 13");
    }
}

  

