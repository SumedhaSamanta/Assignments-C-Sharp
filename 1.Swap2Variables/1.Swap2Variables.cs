using System;
//C# Program to Swap Values of Two Variables.
public class Swap2Variables
{
	private float variable1;
	private float variable2;
	public Swap2Variables(ref float variable1, ref float variable2)
	{
		this.variable1 = variable1;
		this.variable2 = variable2;
        this.swap();
    }
	private void setVariable1(float variable1)
	{
		this.variable1 = variable1;
	}
	public float getVariable1()
	{
		return this.variable1;
	}
    private void setVariable2(float variable2)
    {
        this.variable2 = variable2;
    }
    public float getVariable2()
    {
        return this.variable2;
    }
    private void swap()
	{
		float buffer = this.variable1;
		this.variable1 = this.variable2;
		this.variable2 = buffer;
	}
}
public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Please enter the 2 values to be swapped");
        Console.WriteLine("Please enter the first value:");
        float variable1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second value:");
        float variable2 = float.Parse(Console.ReadLine());
		Console.WriteLine("Before swapping, first value is {0} and second value is {1}",variable1,variable2);
		Swap2Variables swap2Variables = new Swap2Variables(ref variable1, ref variable2);
		variable1 = swap2Variables.getVariable1();
		variable2 = swap2Variables.getVariable2();
        Console.WriteLine("After swapping, first value is {0} and second value is {1}", variable1, variable2);
    }
}