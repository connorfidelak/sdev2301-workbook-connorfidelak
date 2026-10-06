using lesson_16_IntroEFCoreDbContext;

using var context = new AppDbContext();
context.Database.EnsureCreated();

if (!context.Products.Any())
{
    context.Products.AddRange(
    new Product { Name = "Keyboard", Price = 49.99m },
    new Product { Name = "Mouse", Price = 24.99m },
    new Product { Name = "Monitor", Price = 219.99m });
}

if (!context.Products.Any())
{
    // AddRange code from the previous slide
    var rowsSaved = context.SaveChanges();
    Console.WriteLine($"{rowsSaved} rows saved.");
}
