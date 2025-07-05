//using MyFirstConsoleApp_6363862;
//using MyFirstConsoleApp_6363862.Models;

//class Program
//{
//    static async Task Main(string[] args)
//    {
//        using var context = new AppDbContext();

//        // Insert initial data
//        var electronics = new Category { Name = "Electronics" };
//        var groceries = new Category { Name = "Groceries" };

//        await context.Categories.AddRangeAsync(electronics, groceries);

//        var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
//        var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

//        await context.Products.AddRangeAsync(product1, product2);

//        await context.SaveChangesAsync();

//        Console.WriteLine("Data saved successfully!");
//    }
//}

using Microsoft.EntityFrameworkCore;
using MyFirstConsoleApp_6363862;

class Program
{
    static async Task Main(string[] args)
    {
        // Create the database context to access tables
        using var context = new AppDbContext();

        // STEP 1: Retrieve All Products
        Console.WriteLine("🔎 Retrieving All Products:");
        var products = await context.Products.ToListAsync(); // Gets all products from the table

        foreach (var p in products)
        {
            // Display each product's name and price
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }

        // STEP 2: Find a Product by Primary Key (Id = 1)
        Console.WriteLine("\n🔍 Finding Product by ID = 1:");
        var product = await context.Products.FindAsync(1); // Uses the primary key
        Console.WriteLine($"Found: {product?.Name}"); // Safe access using null check

        // STEP 3: Find First Product with Price > 50,000
        Console.WriteLine("\n💸 Finding Expensive Product (Price > ₹50000):");
        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000); // Applies a filter
        Console.WriteLine($"Expensive: {expensive?.Name}");
    }
}

