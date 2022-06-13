using System;
namespace prototype
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Student s1 = new Student();
			s1.Id = 143;
			s1.name = "Akshay";
			Student s2 = s1.Clone();
			s2.name = "Akii";
			s2.Id = 123;
			Console.WriteLine(s1.name);
			Console.WriteLine(s1.Id);
			Console.WriteLine(s2.name);
			Console.WriteLine(s2.Id);
		}
	}
}