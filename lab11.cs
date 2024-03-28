using System;

class GenericClass<T>
{
    private T genericField;

    public GenericClass(T value)
    {
        genericField = value;
    }

    public void Display()
    {
        Console.WriteLine($"Generic field value: {genericField}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of GenericClass with int type
        GenericClass<int> intObj = new GenericClass<int>(10);
        intObj.Display(); // Output: Generic field value: 10

        // Creating an instance of GenericClass with string type
        GenericClass<string> stringObj = new GenericClass<string>("Hello");
        stringObj.Display(); // Output: Generic field value: Hello
        Console.WriteLine("Lab No:11");
        Console.WriteLine("Name: Nirajan Bhattarai");
        Console.WriteLine("Roll No.: 13");
    }
}
