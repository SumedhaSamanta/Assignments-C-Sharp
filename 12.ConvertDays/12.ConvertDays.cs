using System;
//C# Program to convert days to years, weeks and days
class ConvertDays
{
    public void DaysToYMD(int days, ref int[] result)
    {
        int years = days / 365;
        days = days % 365;
        int months = days / 30;
        days = days % 30;
        result[0] = years;
        result[1] = months;
        result[2] = days;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of days:");
        int days = int.Parse(Console.ReadLine());
        int[] result = { 0, 0, 0 };
        ConvertDays c = new ConvertDays();
        c.DaysToYMD(days, ref result);
        Console.WriteLine("{0} days = {1} years, {2} months and {3} days", days, result[0], result[1], result[2]);
    }
}