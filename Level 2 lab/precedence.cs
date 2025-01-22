using System;

class precedence{
	public static void Main(String [] args){
		Console.WriteLine("Enter a");
		int a= Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter b");
		int b= Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter c");
		int c= Convert.ToInt32(Console.ReadLine());
		int ans1 = a + b * c;
		int ans2 = a * b + c;
		int ans3 = c + a/b;
		int ans4 = a % b + c;
		Console.WriteLine("The results of the Operations are "+ans1+","+ans2+","+ans3+" and "+ans4);
	}
}