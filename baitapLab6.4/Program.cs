using System;

public class TestDelegate
{
    public delegate void IntAction(int act);
    public static void PrintInt(int act)
    {
        Console.WriteLine(act);
    }
    public static void Perform(IntAction act, int[] a)
    {
        foreach (int i in a)
        {
            act(i);
        }
    }
}
public class Program
{
    static void Main(string[] args)
    {
        TestDelegate.IntAction act = TestDelegate.PrintInt;
        act(42);
        int[] a = new int[5] { 1, 2, 3, 4, 5 };
        Console.WriteLine("--------------");
        TestDelegate.Perform(act, a);
    }
}