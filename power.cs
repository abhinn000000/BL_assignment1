using System;

class power{
	public static void Main(String [] args){
		Console.WriteLine("Input base:");
		double numbase = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter power:");
		double numpow = Convert.ToDouble(Console.ReadLine());
		double ans= Math.Pow(numbase,numpow);
		Console.WriteLine("The ans is :"+ ans);
	}
}