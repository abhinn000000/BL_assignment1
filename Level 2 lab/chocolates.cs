using System;

class chocolates{
	public static void Main(String [] args){
		Console.WriteLine("Enter number of children");
		int numberOfChildren = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter number of chocolates");
		int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
		
		int equal = numberOfChocolates/numberOfChildren;
		int remaining = numberOfChocolates%numberOfChildren;
		
		Console.WriteLine("The number of chocolates each child gets is "+equal+" and the number of remaining chocolates is "+remaining);
	}
}