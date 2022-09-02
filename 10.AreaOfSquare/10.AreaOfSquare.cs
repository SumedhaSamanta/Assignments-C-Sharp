using System;
//C# Program to Area of Square
public class AreaOfSquare
{
    public float calculateArea(float side)
    {
        return side * side;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        float result;
        AreaOfSquare area = new AreaOfSquare();
        Console.WriteLine("Enter the side of the square:");
        float side = float.Parse(Console.ReadLine());
        result = area.calculateArea(side);
        Console.WriteLine("Area of square with side {0} is {1}", side, result);
    }
}
