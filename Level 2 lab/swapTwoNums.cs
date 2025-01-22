using System;

class swapTwoNums{
	public static void Main(String [] args){
		Console.WriteLine("Enter first number");
		int number1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter second number");
		int number2 = Convert.ToInt32(Console.ReadLine());
		int number3 = number1;
		number1= number2;
		number2 = number3;
		Console.WriteLine("The swapped numbers are "+number1+" and "+ number2);
	}
}