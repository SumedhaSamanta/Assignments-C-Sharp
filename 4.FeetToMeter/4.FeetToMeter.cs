using System;
//C# Program to convert feet to meter
public class FeetToMeter
{
    public double feetToMeter(double l)
    {
        return l / 3.281;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        FeetToMeter feetToMeter = new FeetToMeter();
        double input, result;
        Console.WriteLine("Enter the length in feet:");
        input = double.Parse(Console.ReadLine());
        result = feetToMeter.feetToMeter(input);
        Console.WriteLine("{0} feet = {1} meter", input, result);
    }
}

