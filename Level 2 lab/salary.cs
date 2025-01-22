using System;

class salary{
	public static void Main(String [] args){
		Console.WriteLine("Enter salary");
		double salary = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter bonus");
		double bonus = Convert.ToDouble(Console.ReadLine());
		double total = salary + bonus;
		Console.WriteLine("The salary in INR is "+salary+" and bonus is "+bonus+" Hence, Total Income is INR "+total);
	}
}