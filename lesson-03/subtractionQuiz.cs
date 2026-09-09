Random random = new();

int a = Random.Next(1, 10);

int b = Random.Next(1, 10);

if (a < b) (a, b) = (b, a);

Console.WriteLine($"{a} - {b}");