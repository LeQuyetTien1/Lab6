using System;

public class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[4];
        try
        {
            for (int i = 0; i <= a.Length; i++)
            {
                Console.Write("a[{0}]: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Vuot qua pham vi mang");
        }
        catch (ArrayTypeMismatchException)
        {
            Console.WriteLine("Kieu du lieu nhap vao sai");
        }
        Console.ReadKey();
        bool t = true;
        try
        {
            char c = Convert.ToChar(t);
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Khong the ep kieu");
        }
    }
}