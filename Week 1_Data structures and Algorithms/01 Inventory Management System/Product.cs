namespace MyFirstProgram;

public class Product
{
    public int ProductId { get; set; }
    public String ProductName { get; set; }
    public int ProductQuantity { get; set; }
    public double ProductPrice { get; set; }

    public Product(int productId, String productName, int productQuantity, double productPrice)
    {
        this.ProductId = productId;
        this.ProductName = productName;
        this.ProductQuantity = productQuantity;
        this.ProductPrice = productPrice;
    }

    public override string ToString()
    {
        return $"product [productId: {this.ProductId}, productName: {this.ProductName}, productQuantity: {this.ProductQuantity}, productPrice: {this.ProductPrice}]";
    }

}