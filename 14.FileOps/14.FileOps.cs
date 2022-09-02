using System;
using System.IO;
//C# program to read and write into a text file. (.txt file)
public class FileOps
{
    public void read(string filePath)
    {
        try
        {
            Console.WriteLine(File.ReadAllText(filePath));
            Console.ReadKey();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void write(string filePath, string content)
    {
        try
        {
            File.WriteAllText(filePath, content);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void append(string filePath, string content)
    {
        try
        {
            File.AppendAllText(filePath, content);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        FileOps fileOps = new FileOps();
        Console.WriteLine("Enter the name of the file with it's path:");
        string filePath = Console.ReadLine();
        string content;
        Console.WriteLine("1.Read a file\t2.Write into a file\t3.Append to an existing file");
        Console.WriteLine("Please enter your choice");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                fileOps.read(filePath);
                break;
            case 2:
                Console.WriteLine("Enter the content you want to write:");
                content = Console.ReadLine();
                fileOps.write(filePath, content);
                break;
            case 3:
                Console.WriteLine("Enter the content you want to append:");
                content = Console.ReadLine();
                fileOps.append(filePath, content);
                break;
            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }
    }
}