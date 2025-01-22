using System;

class profit {
	public static void Main(String [] args){
		int cp = 129;
		int sp = 191;
		int profit = sp - cp;
		double per= (profit*100)/cp;
		Console.WriteLine("The cost price in INR" + cp +" and Selling price is INR "+sp);
		Console.WriteLine("The Profit in INR "+profit+" and the Profit Percentage is "+per);
	}
}