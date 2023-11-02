using System;

public class TestDelegate
{
    public delegate void IntAction(int act);
    public event IntAction Action;
    public void PrintInt(int act)
    {
        Console.WriteLine(act);
    }
    public void Perform(IntAction act, int[] a)
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
        TestDelegate t= new TestDelegate();
        /*TestDelegate.IntAction act = t.PrintInt;
        act(42);
        int[] a = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine("--------------");
        t.Perform(act, a);*/
        t.Action += new TestDelegate.IntAction(t.PrintInt);
        t.PrintInt(42);
    }
}