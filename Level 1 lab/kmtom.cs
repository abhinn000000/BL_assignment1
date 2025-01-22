using System;

class kmtom{
	public static void Main (String [] args){
		Console.WriteLine("Enter the distance in km");
		double km = Convert.ToDouble(Console.ReadLine());
		double miles = km * 0.62137119;
		Console.WriteLine("The total miles is "+ miles+ " for the given "+km+" km");
	}
}