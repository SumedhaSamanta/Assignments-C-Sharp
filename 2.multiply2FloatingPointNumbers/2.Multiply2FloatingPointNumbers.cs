using System;
//C# Program to Multiply two Floating Point Numbers
public class Multiply2FloatingPointNumbers
{
    public float multiply(float number1, float number2)
	{
		return number1 * number2;
	}
}
public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter two numbers to be multiplied");
        Console.WriteLine("Please enter the first value:");
        float number1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second value:");
        float number2 = float.Parse(Console.ReadLine());
        Multiply2FloatingPointNumbers multiply2FloatingPointNumbers = new Multiply2FloatingPointNumbers();
		float product = multiply2FloatingPointNumbers.multiply(number1, number2);
        Console.WriteLine("{0} x {1} = {2}",number1,number2,product);
    }
}
