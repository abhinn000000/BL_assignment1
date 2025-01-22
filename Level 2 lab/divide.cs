using System;

class divide{
	public static void Main(String [] args){
		Console.WriteLine("Enter the first number");
		double number1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the second number");
		double number2 = Convert.ToDouble(Console.ReadLine());
		double quotient = number1 / number2;
		double remainder = number1 % number2;
		Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder+" of two numbers "+number1+" and "+number2 );
	}
}