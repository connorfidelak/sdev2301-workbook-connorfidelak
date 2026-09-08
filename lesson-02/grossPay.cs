Console.WriteLine("What is your hourly rate? ");
string rate = Console.ReadLine();
decimal ratedec = decimal.Parse(rate);
Console.WriteLine("How many hours did you work this week?");
string hours = Console.ReadLine();
decimal hoursdec = decimal.Parse(hours);

decimal total = ratedec * hoursdec;

Console.WriteLine($"You will be payed {total} for this week");