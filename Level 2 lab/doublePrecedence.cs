using System;

class doublePrecedence{
	public static void Main(String [] args){
		Console.WriteLine("Enter a");
		double a= Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter b");
		double b= Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter c");
		double c= Convert.ToDouble(Console.ReadLine());
		double ans1 = a + b * c;
		double ans2 = a * b + c;
		double ans3 = c + a/b;
		double ans4 = a % b + c;
		Console.WriteLine("The results of the Operations are "+ans1+","+ans2+","+ans3+" and "+ans4);
	}
}