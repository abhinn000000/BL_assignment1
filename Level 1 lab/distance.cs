using System;

class distance{
	public static void Main(String [] args){
		Console.WriteLine("Enter the distance in feet");
		double feet = Convert.ToDouble(Console.ReadLine());
		double yard = feet/3;
		double mile = yard/1760;
		Console.WriteLine("The distance in feet,yard and miles is "+feet+" , "+yard+" and "+ mile);
	}
}