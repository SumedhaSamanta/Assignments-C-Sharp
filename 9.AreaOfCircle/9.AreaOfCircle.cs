using System;
//C# Program to Area of Circle
public class AreaOfCircle
{
    const float pi = 3.14F;
    public float calculateArea(float radius)
    {
         return pi * radius * radius;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        float result;
        AreaOfCircle area = new AreaOfCircle();
        Console.WriteLine("Enter the radius of the circle:");
        float radius = float.Parse(Console.ReadLine());
        result = area.calculateArea(radius);
        Console.WriteLine("Area of circle with radius {0} is {1}", radius, result);
    }
}
