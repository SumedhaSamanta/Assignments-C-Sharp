using System;
//C# Program to convert feet to meter
public class CelsiusToFahrenheit
{
    public double convert(double t)
    {
        return (1.8 * t) + 32;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        CelsiusToFahrenheit celsiusToFahrenheit = new CelsiusToFahrenheit();
        double input, result;
        Console.WriteLine("Enter the temperature in Celsius:");
        input = double.Parse(Console.ReadLine());
        result = celsiusToFahrenheit.convert(input);
        Console.WriteLine("{0} celsius = {1} fahrenheit", input, result);
    }
}

