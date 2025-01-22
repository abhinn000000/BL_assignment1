using System;

class square{
	public static void Main(String [] args){
		Console.WriteLine("Enter the perimeter of the square");
		double peri = Convert.ToDouble(Console.ReadLine());
		double side = peri/4;
		Console.WriteLine("The length of the side is "+side+ " whose perimeter is "+peri);
	}
}