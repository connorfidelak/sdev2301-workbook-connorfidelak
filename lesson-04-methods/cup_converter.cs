class Program
{
    static void Main()
    {
        double cups = GetCups();
        double ounces = CupsToOunces(cups);
        DisplayResults(cups, ounces);
    }
    static double GetCups()
    {
        double cups = 0;
        Console.WriteLine("Enter amount of cups: ");
        // double cups = double.Parse(Console.ReadLine() ?? "");
        while (!double.TryParse(Console.ReadLine(), out cups))
        {
            Console.WriteLine("Invalid input, no a number. Try again");
            Console.WriteLine("Enter amount of cups: ");
        }
        return cups;
    }
    static double CupsToOunces(double cups)
    {
        return cups * 8;
    }
    static void DisplayResults(double cups, double ounces)
    {
        Console.WriteLine($"{cups} cups = {ounces} ounces");
    }
}