using System;

class Program
{
    static void Main()
    {
        // Jagged array declaration
        int[][] jaggedArray = new int[3][];

        // Initialize elements
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 1, 2 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Accessing elements
        Console.WriteLine(jaggedArray[0][1]); // Output: 2
        Console.WriteLine(jaggedArray[1][0]); // Output: 1
        Console.WriteLine(jaggedArray[2][3]); // Output: 9
    }
}
