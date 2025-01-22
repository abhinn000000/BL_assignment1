using System;

class temperature{
	public static void Main(String [] args){
		Console.WriteLine("Input temp in celcius:");
		double tempInCelsius = Convert.ToDouble(Console.ReadLine());
		double far= (tempInCelsius*1.8)+32;
		Console.WriteLine("The temp in fahrenheit:"+ far);
	}
}