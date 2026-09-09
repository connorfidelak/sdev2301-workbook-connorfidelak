Console.Write("What is your grade: ");

int grade = int.Parse(Console.ReadLine() ?? "0");

if (grade >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (grade >= 80)
{
    Console.WriteLine("Grade: B");
}
else if (grade >= 70)
{
    Console.WriteLine("Grade: C");
}
else
{
    Console.WriteLine("Fail");
}