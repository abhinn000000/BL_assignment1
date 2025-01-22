using System;

class pens {
	public static void Main(String [] args){
		int pens=14;
		int students=3;
		int remaining= pens%students;
		int equal = pens/students;
		Console.WriteLine("The Pen per student "+equal + " and the remaining pens not distributed are "+remaining);
	}
}