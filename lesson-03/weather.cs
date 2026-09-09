Console.Write("Temperature in celsius: ");

int temp = int.Parse(Console.ReadLine() ?? "0");

if (temp >= 20)
{
    Console.WriteLine("Warm");
}
else
{
    Console.WriteLine("Cool");
}