using MyFirstConsoleApp_6363862;
using MyFirstConsoleApp_6363862.Models;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // Insert initial data
        var electronics = new Category { Name = "Electronics" };
        var groceries = new Category { Name = "Groceries" };

        await context.Categories.AddRangeAsync(electronics, groceries);

        var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
        var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

        await context.Products.AddRangeAsync(product1, product2);

        await context.SaveChangesAsync();

        Console.WriteLine("Data saved successfully!");
    }
}
