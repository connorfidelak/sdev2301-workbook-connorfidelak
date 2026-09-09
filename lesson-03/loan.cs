Console.WriteLine("Enter your salary:");
int salary = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

Console.WriteLine("Enter how many years you have been working:");
int years = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

bool salaryOk = salary >= 30000;
bool experienceOk = years >= 2;

if (salaryOk && experienceOk)
{
    Console.WriteLine("Qualifies");
}
else
{
    Console.WriteLine("Does not qualify");
}