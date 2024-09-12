namespace Models;

public class Milk : Product
{ 
    protected string Expiry { get; set; }

    public Milk(string ProductType, string name, decimal price, int quantity, string expiry) : base(ProductType, name, price, quantity)
    {
        Expiry = expiry;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{Name} ---- {Price}kr ---- Qnt: {Quantity} ---- Expiry Date: {Expiry} ");
    }
}