namespace Models;

public abstract class Product
{
    protected string ProductType { get; set; }
    protected string Name { get; set; }
    protected decimal Price { get; set; }
    protected int Quantity { get; set; }

    public Product(string ProductType,string name, decimal price, int quantity)
    {
        this.ProductType = ProductType;
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public abstract void DisplayInfo();
}