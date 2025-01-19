using System;

class rectangle{
	public static void Main(String [] args){
		Console.WriteLine("Input length:");
		double length = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter width:");
		double width = Convert.ToDouble(Console.ReadLine());
		double area= 2 * (length + width);
		Console.WriteLine("The area of the rectangle is :"+ area);
	}
}