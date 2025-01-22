using System;

class inputDiscount{
	public static void Main(String [] args){
		Console.WriteLine("Enter fee amount");
		double fee = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter discount amount");
		double discount = Convert.ToDouble(Console.ReadLine());
		double afterDiscount =fee * discount/100;
		double amount = fee - afterDiscount;
		Console.WriteLine("The discount amount in INR "+afterDiscount+" and final discounted fee in INR "+ amount);
	}
}