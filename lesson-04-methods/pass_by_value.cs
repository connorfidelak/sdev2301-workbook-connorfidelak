using System.Security.Authentication.ExtendedProtection;

class Program
{
    static void Main()
    {
        int value = 20;
        Change(value);
        Console.WriteLine(value);
    }
    static void Change(int num)
    {
        num = 100;
    }
}