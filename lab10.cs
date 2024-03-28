using System;
using System.Collections; // For non-generic collections
using System.Collections.Generic; // For generic collections

class Program
{
    static void Main(string[] args)
    {
        // Non-generic collection (ArrayList)
        ArrayList arrayList = new ArrayList();
        arrayList.Add("apple");
        arrayList.Add("banana");
    

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Generic collection (List<T>)
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
          Console.WriteLine("Lab No: 10");
        Console.WriteLine("Name: Nirajan Bhattarai");
        Console.WriteLine("Roll No.: 13");
    }
}
