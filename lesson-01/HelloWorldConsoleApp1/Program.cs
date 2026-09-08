namespace HelloWorldConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Visual Studio World!");
            Console.Write("Next line");
            Console.WriteLine();
            Console.WriteLine("This writes to the same line");
            Console.WriteLine("\nLine 1\nLine 2 \nLine 3");
            Console.WriteLine("""
                Line 1
                Line 2
                Line 3
                """); // using raw string literal for multiple lines of text
        }
    }
}