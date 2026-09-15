class Program
{
    static void Main()
    {
        Greet("Mina");
        Greet(greeting: "Welcome", name: "Mina");
    }
    static void Greet(string name, string greeting = "Hello")
    {
        Console.WriteLine($"{greeting}, {name}!");
    }
}