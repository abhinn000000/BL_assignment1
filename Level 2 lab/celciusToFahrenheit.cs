using System;

class celciusToFahrenheit{
	public static void Main(String [] args){
		Console.WriteLine("Input temp in celcius:");
		double tempInCelsius = Convert.ToDouble(Console.ReadLine());
		double far= (tempInCelsius*1.8)+32;
		Console.WriteLine("The "+tempInCelsius+" Celcius is "+far+" Fahrenheit");
	}
}