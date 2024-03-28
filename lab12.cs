using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   Console.WriteLine("Enter text ");
        // Read input from the keyboard
        string input = Console.ReadLine();
        // Write input to a file
        using (StreamWriter writer = new StreamWriter("output22.txt"))
        {
            writer.WriteLine(input);
        }
        Console.WriteLine("Input written to file successfully.");
        Console.WriteLine("Lab No:12");
        Console.WriteLine("Name: Nirajan Bhattarai");
        Console.WriteLine("Roll No.: 13");
    }
}

