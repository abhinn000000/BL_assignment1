using System;

class earth{
	public static void Main(String [] args){
		int radius = 6378;
		double mile1 = 0.62137119;
		double volumeKm = 4.0/3.0* Math.PI * Math.Pow(radius,3);
		double volumeMile = volumeKm * mile1;
		Console.WriteLine("The volume of Earth in cubic kilometers is "+ volumeKm+ " and cubic miles is "+ volumeMile);
	}
}