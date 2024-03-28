using System;
using System.Runtime.CompilerServices;

namespace ConstructorTypes
{
    public class Student
    {
        public string name;
        public static int count = 0;
        // Default Constructor
        public Student()
        {
            name = "";
            count++;
        }
        // Parameterized Constructor
        public Student(string n)
        {
            name = n;
            count++;
        }
        // Copy Constructor
        public Student(Student obj)
        {
            name = obj.name;
            count++;
        }
        // Private Constructor
        private Student(string n, int c)
        {
            name = n;
            count = c;
        }
        // Static Constructor
        static Student()            // Runs anyway before Main() method
        {
            count = 10;
        }
        public void Display()
        {
            Console.WriteLine("Name: " + name);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Student obj1 = new Student();
            obj1.Display();
            Student obj2 = new Student("nirajan");
            obj2.Display();
            Student obj3 = new Student(obj2);
            obj3.Display();
            //Student s4 = new Student("Shyam", 10);          // Private Class Restriction

            Console.WriteLine("Count: " + Student.count);
            Console.WriteLine("Lab No: 1");
            Console.WriteLine("Name: Nirajan Bhattarai");
            Console.WriteLine("Roll No.: 13");
        }
    }
}