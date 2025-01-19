using System;

class average{
	public static void Main(String [] args){
		Console.WriteLine("Input first:");
		double first = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter second:");
		double second = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter Third:");
		double third = Convert.ToDouble(Console.ReadLine());
		double average= (first + second + third)/3;
		Console.WriteLine("The average is :"+ average);
	}
}