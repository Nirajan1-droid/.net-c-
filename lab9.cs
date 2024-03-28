using System;

// Delegate (a)
public delegate void MyDelegate(string message);

class Program
{
    // Multicast delegate (b)
    public static void Main(string[] args)
    {
        MyDelegate delegate1 = Method1;
        MyDelegate delegate2 = Method2;

        MyDelegate multicastDelegate = delegate1 + delegate2;
        multicastDelegate("Multicast delegate example"); // Output: Method 1: Multicast delegate example, Method 2: Multicast delegate example

        // Func delegate (c)
        Func<int, int, int> add = Add;
        int result = add(3, 5);
        Console.WriteLine($"Addition result using Func delegate: {result}"); // Output: Addition result using Func delegate: 8

        // Action delegate (d)
        Action<string> printMessage = PrintMessage;
        printMessage("Printing message using Action delegate"); // Output: Printing message using Action delegate

        // Anonymous method (e)
        MyDelegate anonymousDelegate = delegate (string message)
        {
            Console.WriteLine($"Anonymous method: {message}");
        };
        anonymousDelegate("Anonymous method example"); // Output: Anonymous method: Anonymous method example

        // Event in C# (f)
        var publisher = new Publisher();
        var subscriber1 = new Subscriber("Subscriber 1");
        var subscriber2 = new Subscriber("Subscriber 2");

        publisher.MyEvent += subscriber1.OnMyEvent;
        publisher.MyEvent += subscriber2.OnMyEvent;

        publisher.RaiseEvent("Event raised!"); // Output: Subscriber 1 received: Event raised!, Subscriber 2 received: Event raised!
        Console.WriteLine("Lab No: 9");
        Console.WriteLine("Name: Nirajan Bhattarai");
        Console.WriteLine("Roll No.: 13");
    }

    public static void Method1(string message)
    {
        Console.WriteLine($"Method 1: {message}");
    }

    public static void Method2(string message)
    {
        Console.WriteLine($"Method 2: {message}");
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}

// Event in C# (f)
public class Publisher
{
    public event MyDelegate MyEvent;

    public void RaiseEvent(string message)
    {
        MyEvent?.Invoke(message);
    }
}

public class Subscriber
{
    private string Name;

    public Subscriber(string name)
    {
        Name = name;
    }

    public void OnMyEvent(string message)
    {
        Console.WriteLine($"{Name} received: {message}");
    }
}
