using Lab6;
using System;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    static void Main(string[] args)
    {
        Student std=new Student();
        Console.WriteLine("Moi nhap thong tin hoc sinh: ");
        Console.Write("Id: ");
        std.id = int.Parse(Console.ReadLine());
        Console.Write("Name: ");
        std.name = Console.ReadLine();
        Console.Write("Theory mark: ");
        try
        {
            std.theorymark = double.Parse(Console.ReadLine());
            if(std.theorymark < 0||std.theorymark>10)
            {
                throw new InvalidMarkException();
            }
        }
        catch (InvalidMarkException ex)
        {
            Console.WriteLine(ex.Message);
        }
        try
        {
            std.labmark = double.Parse(Console.ReadLine());
            if (std.labmark < 0||std.labmark>10)
            {
                throw new InvalidMarkException();
            }
        }
        catch (InvalidMarkException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine(std);
    }
}