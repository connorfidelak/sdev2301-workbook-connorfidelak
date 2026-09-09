Console.WriteLine("Pick a number between 1-4 for your choices:");
int choice = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine();

switch (choice)
{
    case 1:
        Console.WriteLine("Chicken");
        break;
    case 2:
        Console.WriteLine("Steak");
        break;
    case 3:
        Console.WriteLine("Salmon");
        break;
    case 4:
        Console.WriteLine("Vegetables");
        break;
    default:
        Console.WriteLine("Item not on the menu");
        break;
}