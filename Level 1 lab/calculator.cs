using System;

class calculator{
	public static void Main(String [] args){
		Console.WriteLine("Enter first number");
		double number1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter second number");
		double number2 = Convert.ToDouble(Console.ReadLine());
		double sum = number1 + number2;
		double diff = number1 - number2;
		double product = number1 * number2;
		double div = number1/number2;
		Console.WriteLine("The addition,subtraction,multiplication and division value of 2 numbers "+number1+" and "+number2+" is "+sum+","+diff+","+product+","+" and "+div);
	}
}