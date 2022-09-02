using System;
//C# Program to perform all arithmetic operations
public class Calculator
{
    public float add(float number1, float number2)
    {
        return number1 + number2;
    }

    public float subtract(float number1, float number2)
    {
        return number1 - number2;
    }

    public float multiply(float number1, float number2)
    {
        return number1 * number2;
    }

    public float divide(float number1, float number2)
    {
        return number1 / number2;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        float number1;
        float number2;
        float result;
        Console.WriteLine("1.Add\t2.Subtract\t3.Multiply\t4.Divide");
        Console.WriteLine("Please enter your choice");
        int choice = int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
                Console.WriteLine("Enter two numbers to be added");
                Console.WriteLine("Please enter the first value:");
                number1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second value:");
                number2 = float.Parse(Console.ReadLine());
                result = calculator.add(number1, number2);
                Console.WriteLine("{0} + {1} = {2}", number1, number2, result);
                break;
            case 2:
                Console.WriteLine("Enter two numbers to be subtracted");
                Console.WriteLine("Please enter the minuend:");
                number1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the subtrahend:");
                number2 = float.Parse(Console.ReadLine());
                result = calculator.subtract(number1, number2);
                Console.WriteLine("{0} - {1} = {2}", number1, number2, result);
                break;
            case 3:
                Console.WriteLine("Enter two numbers to be multiplied");
                Console.WriteLine("Please enter the first value:");
                number1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second value:");
                number2 = float.Parse(Console.ReadLine());
                result = calculator.multiply(number1, number2);
                Console.WriteLine("{0} x {1} = {2}", number1, number2, result);
                break;
            case 4:
                Console.WriteLine("Enter two numbers to be divided");
                Console.WriteLine("Please enter the dividend:");
                number1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the divisor:");
                number2 = float.Parse(Console.ReadLine());
                result = calculator.divide(number1, number2);
                Console.WriteLine("{0} / {1} = {2}", number1, number2, result);
                break;
            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }
    }
}
