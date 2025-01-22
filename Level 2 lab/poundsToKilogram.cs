using System;

class poundsToKilogram{
	public static void Main(String [] args){
		Console.WriteLine("Enter Weight in pounds");
		double pound = Convert.ToDouble(Console.ReadLine());
		
		double kg = pound/2.2;
		Console.WriteLine("The weight of the person in pounds is "+pound+" and in kg is "+kg);
	}
}