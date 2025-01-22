using System;

class height{
	public static void Main(String [] args){
		Console.WriteLine("Enter height in cms");
		double cm = Convert.ToDouble(Console.ReadLine());
		double feet = cm/30.48;
		double inch = (cm%30.48)/2.54;
		int feetWhole= (int)feet;
		Console.WriteLine("Your height in cm is "+cm+" while in feet is "+feetWhole+" and inches is "+inch);
	}
}