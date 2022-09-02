using System;
//C# Program to Area of Rectangle
public class AreaOfRectangle
{
    public float calculateArea(float length, float breadth)
    {
        return length * breadth;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        float result;
        AreaOfRectangle area = new AreaOfRectangle();
        Console.WriteLine("Enter the length of the rectangle:");
        float length = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the breadth of the rectangle:");
        float breadth = float.Parse(Console.ReadLine());
        result = area.calculateArea(length, breadth);
        Console.WriteLine("Area of rectangle with length {0} and breadth {1} is {2}", length, breadth, result);
    }
}
