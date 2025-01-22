using System;

class quantity{
	public static void Main(String [] args){
		Console.WriteLine("Enter the price of a single product");
		double price =Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the Quantity required");
		int quantity = Convert.ToInt32(Console.ReadLine());
		double totalPrice = price * quantity;
		Console.WriteLine("The total purchase in INR is "+totalPrice+" if the quantity is "+quantity+" and unit price is INR "+ price);
	}
}