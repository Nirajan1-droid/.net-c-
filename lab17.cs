using System;
using System.Threading.Tasks;

namespace AsyncAwaitApp
{
	public class Program
	{
		public static async Task MethodA()
		{
			await Task.Run(() => {
				for (int i = 0; i < 100; i++)
				{
					Console.WriteLine("A");
				}
			});
		}
		public static void MethodB()
		{
			for (int i = 0; i < 20; i++)
			{
				Console.WriteLine("B");
			}
		}
		static void Main(string[] args)
		{
			MethodA();
			MethodB();
			Console.WriteLine("Lab No: 17");
			Console.WriteLine("Name: Nirajan Bhattarai");
			Console.WriteLine("Roll No.: 13");
		}
	}
}