using lesson_17_EFCoreCRUDRelationships;

using var context = new AppDbContext();

if (!context.Categories.Any())
{
    var category = new Category { Name = "Electronics" };
    category.Products.Add(new Product { Name = "Keyboard", Price = 49.99m });
    category.Products.Add(new Product { Name = "Mouse", Price = 24.99m });

    context.Add(category);
    context.SaveChanges();
}
