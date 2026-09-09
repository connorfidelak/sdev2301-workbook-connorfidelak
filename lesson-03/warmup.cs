using static System.Console;

Write("What is your age? ");
int age = int.Parse(ReadLine() ?? "0");

if (age >= 18)
{
    WriteLine("Adult");
}
else
{
    WriteLine("Child");
}