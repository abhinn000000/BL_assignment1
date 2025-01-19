using System;

class add{
	public static void Main(String [] args){
		Console.WriteLine("Input first number:");
		int first = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Input second number");
		int second = Convert.ToInt32(Console.ReadLine());
		int sum= first + second;
		Console.WriteLine("The sum is:"+ sum);
	}
}