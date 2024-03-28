using System;

class Program
{
    static void Main(string[] args)
    {
        // Exception handling using try, catch, and finally blocks (a)
        try
        {
            int result = Divide(10, 0); // Attempting to divide by zero
            Console.WriteLine("Result: " + result); // This line will not be executed
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message); // Output: Exception caught: Attempted to divide by zero
        }
        finally
        {
            Console.WriteLine("Finally block executed"); // Output: Finally block executed
        }

        // Exception propagation using throw keyword (b)
        try
        {
            ProcessData(120); // Calling a method that throws an exception
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Exception caught in Main: " + ex.Message); // Output: Exception caught in Main: Invalid data
        }

        // Custom exception handling (c)
        try
        {
            CheckAge(15); // Calling a method that throws a custom exception
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine("Custom Exception caught: " + ex.Message); // Output: Custom Exception caught: Age must be 18 or above
        }
        Console.WriteLine("Lab No:12");
        Console.WriteLine("Name: Nirajan Bhattarai");
        Console.WriteLine("Roll No.: 13");

    }

    // Method that throws DivideByZeroException
    static int Divide(int dividend, int divisor)
    {
        return dividend / divisor;
    }

    // Method that throws an exception using throw keyword
    static void ProcessData(int value)
    {
        if (value > 100)
        {
            throw new ArgumentException("Invalid data");
        }
    }

    // Custom exception class
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    // Method that throws a custom exception
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Age must be 18 or above");
        }
    }
}

