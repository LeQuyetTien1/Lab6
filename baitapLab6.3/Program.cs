using baitapLab6._3;
using System;
public class AmountException: Exception
{
    public AmountException() : base("Giang vien phai co luong cao hon 60,000$ va thuong be hon 10,000$")
    {
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Lecture a=new Lecture();
        Console.WriteLine("Nhap thong tin: ");
        Console.Write("Name: "); 
        a.Name = Console.ReadLine();
        Console.Write("Salary: ");
        try
        {
            a.Salary = double.Parse(Console.ReadLine());
            if (a.Salary < 60000)
            {
                throw new AmountException();
            }
        }
        catch(AmountException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.Write("Bonus: ");       
        try
        {
            a.Bonus = double.Parse(Console.ReadLine());
            if (a.Bonus > 10000)
            {
                throw new AmountException();
            }
        }
        catch (AmountException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("------------------");
        Console.WriteLine(a);
    }
}