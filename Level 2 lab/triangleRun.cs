using System;

class triangleRun{
	public static void Main(String [] args){
		Console.WriteLine("Enter length of first side");
		double side1 = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter length of second side");
		double side2 = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter length of third side");
		double side3 = Convert.ToDouble(Console.ReadLine());
		
		double perimeter = side1 + side2 + side3;
		double rounds = 5000 / perimeter;
		Console.WriteLine("The total number of rounds the athlete will run is "+rounds+" to complete 5 kms");
	}
}