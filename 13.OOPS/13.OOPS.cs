using System;
//C# program showing the different oops concepts: Inheritance, Abstraction, Polymorphism
abstract class Shape //abstraction
{
    public string name;
    public abstract void draw();
    public void numberOfPoints()
    {
        Console.WriteLine("The shape is made up of infinte points");
    }

}

class Quadrilateral: Shape //inheritance
{
    public Quadrilateral(string name)
    {
        this.name = name;
    }
    public override void draw()
    {
        Console.WriteLine("Drawing a " + this.name);
    }
    public void findArea(float side) //polymorphism
    {
        Console.WriteLine("Area of square with side {0} = {1}", side, side * side);
    }
    public void findArea(float length, float breadth)
    {
        Console.WriteLine("Area of rectangle with length {0} and breadth {1} = {2}", length, breadth, length * breadth);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Quadrilateral square = new Quadrilateral("square");
        square.draw();
        square.findArea(6);
        square.numberOfPoints();
        Quadrilateral rectangle = new Quadrilateral("rectangle");
        rectangle.draw();
        rectangle.findArea(3, 4);
    }
}