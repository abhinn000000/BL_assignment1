using System;

class discount{
	public static void Main(String [] args){
		int fee = 125000;
		int discountPercent =10;
		double discount =fee * discountPercent/100;
		double amount = fee - discount;
		Console.WriteLine("The discount amount in INR "+discount+" and final discounted fee in INR "+ amount);
	}
}