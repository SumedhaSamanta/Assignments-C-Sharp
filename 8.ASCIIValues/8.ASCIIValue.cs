using System;
//C# Program to Print ASCII Value
public class ASCIIValue
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the character");
		char ch = Console.ReadKey().KeyChar;
		int ascii = ch;
		Console.WriteLine("\nASCII value of {0} is {1}",ch,ascii);
	}
}
