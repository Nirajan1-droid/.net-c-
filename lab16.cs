using System;
using System.Diagnostics;

// Built-in attribute usage (a)
[Obsolete("This method is deprecated. Use NewMethod instead.")]
class MyClass
{
    [Conditional("DEBUG")]
    public void DebugMethod()
    {
        Console.WriteLine("Debug method called");
    }
}

// Custom attribute definition (b)
[AttributeUsage(AttributeTargets.Method)]
class CustomAttribute : Attribute
{
    public string Description { get; }

    public CustomAttribute(string description)
    {
        Description = description;
    }
}

// Usage of custom attribute (b)
class CustomClass
{
    [Custom("This is a custom method")]
    public void CustomMethod()
    {
        Console.WriteLine("Custom method called");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Built-in attribute usage (a)
        MyClass obj = new MyClass();
        obj.DebugMethod(); // Output: Debug method called

        // Custom attribute usage (b)
        CustomClass customObj = new CustomClass();
        customObj.CustomMethod(); // Output: Custom method called



        Console.WriteLine("Lab No:16");
        Console.WriteLine("Name: Nirajan Bhattarai");
        Console.WriteLine("Roll No.: 13");
    }
}
