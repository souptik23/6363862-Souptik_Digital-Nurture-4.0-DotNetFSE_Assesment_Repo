
class Product
{
    private int productId;
    private String productName;
    private String productCategory;
    
    public int ProductId { get; set; }
    public String ProductName { get; set; }
    public String ProductCategory { get; set; }

    public Product(int productId, String productName, String productCategory)
    {
        this.ProductId = productId;
        this.ProductName = productName;
        this.ProductCategory = productCategory;
    }

    public override string ToString()
    {
        return $"product : [ productId: {ProductId}, productName: {ProductName}, productCategory: {ProductCategory}]";
    }
} 

class Program
{

    public static Product linearSearch(Product[] products , int productId)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == productId)
            {
                return product;
            }
        }

        return null;
    }

    public static Product binarySearch(Product[] products, int productId)
    {
        int start = 0;
        int end = products.Length - 1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (products[mid].ProductId == productId)
            {
                return products[mid];
            }
            else if (products[mid].ProductId < productId)
            {
                start = mid+1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return null;

    }
    
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of products : ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        Product[] products = new Product[num];
        
        // insertion of the products is initialized
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine($"Enter the details for the {i+1}th product ::: ");

            Console.Write($"Enter the product ID : ");
            int id = int.Parse(Console.ReadLine());
            
            Console.Write($"Enter the product name : ");
            String name = Console.ReadLine();
            
            Console.Write($"Enter the product category : ");
            String category = Console.ReadLine();
            
            products[i] = new  Product(id, name, category);
        }
        
        // showing all the products
        foreach (Product product in products)
        {
            Console.WriteLine(product.ToString());
        }
        
        // sort products by product Id
        Array.Sort( products , (a,b)=>a.ProductId.CompareTo(b.ProductId));
        
        // now initializing the searching
        Console.Write("Enter the product id for the search: ");
        int productId = int.Parse(Console.ReadLine());

        
        // linear search in the searching
        Product foundLinear = linearSearch(products, productId);
        if (foundLinear != null)
        {
            Console.WriteLine("Product found in linear search: ");
            Console.WriteLine(foundLinear.ToString());
        }
        
        // binary searching
        Product foundBinary = binarySearch(products, productId);
        if (foundBinary != null)
        {
            Console.WriteLine("Product found in linear search: ");
            Console.Write(foundBinary.ToString());
        }

    }
}