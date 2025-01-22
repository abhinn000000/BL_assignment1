using System;

class fahrenheitToCelcius{
	public static void Main(String [] args){
		Console.WriteLine("Enter the temperature in Fahrenheit");
		double far = Convert.ToDouble(Console.ReadLine());
		double celcius = (far - 32) * 5/9;
		Console.WriteLine("The"+far+"Fahrenheit is"+celcius);
	}
}