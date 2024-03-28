
 using System;

namespace PropertyApp
{
    public class Student
    {
        public string Name { get; set; }            // Auto-Property
        private static int count = 0;
        public int Count                            // Read-Only Property
        {
            get
            {
                return count;
            }
        }
        public Student()
        {
            count++;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "nirajan";

            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Count);

            Console.WriteLine("Lab No: 2");
            Console.WriteLine("Name: Nirajan Bhattarai");
            Console.WriteLine("Roll No.: 13");
        }
    }
}