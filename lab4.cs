using System;

namespace  Indexer
{
	public class Student
	{
		public int Id { get; set; }
		public string Fname { get; set; }
		public string Lname { get; set; }
		// Interger Indexer
		public object this[int i]
		{
			get
			{
				if (i == 0) return Id;
				else if (i == 1) return Fname;
				else if (i == 2) return Lname;
				else return -1;
			}
			set
			{
				if (i == 0) Id = (int)value;
				else if (i == 1) Fname = (string)value;
				else if (i == 2) Lname = (string)value;
				else return;
			}
		}
		// String Indexer
		public object this[string str]
		{
			get
			{
				if (str == "id") return Id;
				else if (str == "Fname") return Fname;
				else if (str == "Lname") return Lname;
				else return -1;
			}
			set
			{
				if (str == "id") Id = (int)value;
				else if (str == "Fname") Fname = (string)value;
				else if (str == "Lname") Lname = (string)value;
				else return;
			}
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Student s1 = new Student();
			s1[0] = 123;
			s1[1] = "nirajan";
			s1[2] = "bhattarai";
			Console.WriteLine(s1[0]);
			Console.WriteLine(s1[1]);
			Console.WriteLine(s1[2]);

			Console.WriteLine();
			Student s2 = new Student();
			s2["id"] = 456;
			s2["Fname"] = "ram";
			s2["Lname"] = "bahadur";
			Console.WriteLine(s2["id"]);
			Console.WriteLine(s2["Fname"]);
			Console.WriteLine(s2["Lname"]);

			 Console.WriteLine("Lab No: 4");
            Console.WriteLine("Name: Nirajan Bhattarai");
            Console.WriteLine("Roll No.: 13");
		}
	}
}