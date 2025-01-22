using System;

class simpleInterest{
	public static void Main(String [] args){
		Console.WriteLine("Input principal:");
		double principal = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter rate:");
		double rate = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter Time:");
		double time = Convert.ToDouble(Console.ReadLine());
		double interest= (principal * rate * time)/100;
		Console.WriteLine("The simple interest is "+ interest+" for Principal "+principal+", Rate of interest "+rate+" and Time "+time);
	}
}