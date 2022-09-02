using System;
//C# program for bubble sort
public class BubbleSort
{
    public void sort(ref int[] a)
    {
        bool flag = false;
        int temp;
        int l = a.Length;
        for (int i = 0; i < l - 1; i++)
        {
            flag = false;
            for (int j = 0; j < l - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    flag = true;
                }
            }
            if (!flag)
                break;

        }
    }
    public void display(int[] a)
    {
        int l = a.Length;
        for (int i = 0; i < l - 1; i++)
        {
            Console.Write("{0}, ", a[i]);
        }
        Console.WriteLine("{0}", a[l - 1]);
    }
}
class Program
{ 
	public static void Main(string[] args)
	{
        BubbleSort bubbleSort = new BubbleSort();
        Console.WriteLine("Please enter the number of elements to be sorted:");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the numbers to be sorted:\n");
        int[] a = new int[length];

        for (int i = 0; i < length; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Before Sorting:");
        bubbleSort.display(a);
        bubbleSort.sort(ref a);
        Console.WriteLine("After Sorting:");
        bubbleSort.display(a);
    }
}
