using System;

class handshakes{
	public static void Main(String [] args){
		Console.WriteLine("Enter the number of students");
		int numberOfStudents =Convert.ToInt32(Console.ReadLine());
		int totalHandshakes = (numberOfStudents * (numberOfStudents-1))/2;
		Console.WriteLine("The maximum number of possible handshakes are "+totalHandshakes);
	}
}