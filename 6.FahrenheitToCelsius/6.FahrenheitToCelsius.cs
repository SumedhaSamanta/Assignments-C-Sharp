using System;

public class FahrenheitToCelsius
{
    public double convert(double t)
    {
        return ((t - 32) * 5) / 9;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius fahrenheitToCelsius = new FahrenheitToCelsius();
        double input, result;
        Console.WriteLine("Enter the temperature in Fahrenheit:");
        input = double.Parse(Console.ReadLine());
        result = fahrenheitToCelsius.convert(input);
        Console.WriteLine("{0} fahrenheit = {1} celsius", input, result);
    }
}
