using System;
//C# Program to find the Size of data types
public class SizeOfDataTypes
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Data type of which you want to know size:");
		Console.WriteLine("1.char\t2.short\t3.int\t4.long\t5.float\t6.double");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Size of char: " + sizeof(char));
                break;
            case 2:
                Console.WriteLine("Size of short: " + sizeof(short));
                break;
            case 3:
                Console.WriteLine("Size of int: " + sizeof(int));
                break;
            case 4:
                Console.WriteLine("Size of long: " + sizeof(long));
                break;
            case 5:
                Console.WriteLine("Size of float: " + sizeof(float));
                break;
            case 6:
                Console.WriteLine("Size of double: " + sizeof(double));
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}
