using System;

class triangle{
	public static void Main(String [] args){
		Console.WriteLine("Enter base of the triangle");
		double base1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter height of the triangle");
		double height = Convert.ToDouble(Console.ReadLine());
		double areacm = 0.5 * base1 * height;
		double areainches = areacm * 0.39370079;
		Console.WriteLine("The area of the triangle in squared cm is "+areacm+" and in squared inches is "+areainches);
		
	}
}