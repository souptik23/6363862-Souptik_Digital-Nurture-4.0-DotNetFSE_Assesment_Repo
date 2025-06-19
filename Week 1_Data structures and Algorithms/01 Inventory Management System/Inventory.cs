using System.Globalization;

namespace MyFirstProgram;

public class Inventory
{
    // here we are using list ds 
    private List<Product> products;

    // constructor to initialize the object 
    public Inventory()
    {
        products = new List<Product>();
    }
    
    public void addProduct(Product product)
    {   
        products.Add(product);
    }
    
    public bool removeProduct(int productId)
    {
        Product productToRemove = null;
        
        foreach (Product product in products)
        {
            if (product.ProductId == productId)
            {
                productToRemove = product;
                Console.WriteLine($"product with the product id {productId} found");
                break;
            }
        }

        if (productToRemove != null)
        {
            products.Remove(productToRemove);
            Console.WriteLine($"Product with ID: {productId} removed.");
            return true;
        }
        else
        {
            Console.WriteLine($"Invalid Product Id: {productId}");
            return false;
        }


        return true;
    }

    public void displayProducts()
    {
        foreach (Product product in products)
        {
            Console.WriteLine(product.ToString());
        }
    }

    public void updateProduct(int productId, String productName, int productQuantity, double productPrice)
    {
        bool found = false;
        foreach (Product product in products)
        {
            if (product.ProductId == productId)
            {
                product.ProductName = productName;
                product.ProductQuantity = productQuantity;
                product.ProductPrice = productPrice;
                
                found = true;

                Console.WriteLine($"product with the product id {productId} has been updated");
            }
        }

        if (!found)
        {
            Console.WriteLine($"Product with the id: {productId} not found");
        }
    }
}