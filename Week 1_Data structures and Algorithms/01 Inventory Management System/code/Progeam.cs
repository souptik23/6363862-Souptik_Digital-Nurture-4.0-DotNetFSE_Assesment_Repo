using System;
using System.Net.Security;
using System.Text;
using MyFirstProgram;


public class Program
{
    public static void Main(string[] args)
    {
        
        Inventory inventory = new Inventory();

        char makeEntry = 'y';

        while (makeEntry == 'y')
        {
            Console.WriteLine("Enter Product Details : ");
            
            Console.Write("Product ID: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Quantity: ");
            int productQuantity = int.Parse(Console.ReadLine());

            Console.Write("Price: ");
            double productPrice = double.Parse(Console.ReadLine());
            
            Product productToAdd = new Product(productId, productName, productQuantity, productPrice);
            
            inventory.addProduct(productToAdd);
            
            Console.WriteLine("want to add more product? : [y/n]" );
            makeEntry = Console.ReadLine().ToLower()[0];
            Console.WriteLine();
        }
        
        // displaying the products in the inventory :)
        Console.WriteLine("Products in the inventory : ");
        inventory.displayProducts();
        
        
        // updating a product in the inventory
        Console.Write("Enter the product Id  you want to update : ");
        int productToUpdateId = int.Parse(Console.ReadLine());
        Console.WriteLine($"Updating of the product {productToUpdateId} has been initiated :");
        
        Console.Write("Product Name: ");
        string productToUpdateName = Console.ReadLine();

        Console.Write("Quantity: ");
        int productToUpdateQuantity = int.Parse(Console.ReadLine());

        Console.Write("Price: ");
        double productToUpdatePrice = double.Parse(Console.ReadLine());

        inventory.updateProduct(productToUpdateId , productToUpdateName, productToUpdateQuantity, productToUpdatePrice);
        
        
        // deleting a product from the inventory
        Console.Write("Enter the product Id to be removed: ");
        int productToRemoveId = int.Parse(Console.ReadLine());
        inventory.removeProduct(productToRemoveId);
        
        // after all showing the inventory:
        Console.WriteLine("Products in the inventory after deletion :");
        inventory.displayProducts();
    }
}
