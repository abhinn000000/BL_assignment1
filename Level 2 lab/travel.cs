using System;

class Travel{
	public static void Main(String [] args){
		Console.WriteLine("Enter name");
		string name = Console.ReadLine();
		
		Console.WriteLine("Enter name of from city");
		string fromCity = Console.ReadLine();
		Console.WriteLine("Enter name of via city");
		string viaCity = Console.ReadLine();
		Console.WriteLine("Enter name of to city");
		string toCity = Console.ReadLine();
		
		Console.WriteLine("Enter the distance fromCity to viaCity");
		double fromCityToviaCitydistance = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the distance viaCity to toCity");
		double viaCityTotoCitydistance = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the time fromCity to viaCity");
		double fromCityToviaCitytime = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the time viaCity to toCity");
		double viaCityTotoCitytime = Convert.ToDouble(Console.ReadLine());
		
		double totalDistance =  fromCityToviaCitydistance + viaCityTotoCitydistance;
		double totalTime =	fromCityToviaCitytime + viaCityTotoCitytime;
		
		Console.WriteLine("The Total Distance travelled by " +name+ " from "+fromCity+" to "+toCity+" via "+viaCity+" is "+totalDistance+" km and the Total Time taken is "+totalTime+" minutes");
		
	}
}