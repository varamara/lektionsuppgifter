namespace Models;

public class DogFood : Product
{
    protected MeatType _meatType { get; set; }

    public DogFood(string ProductType, string name, decimal price, int quantity, MeatType meatType) : base(ProductType, name, price, quantity)
    {
        _meatType = meatType;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{Name} ---- {Price}kr ---- Qnt: {Quantity} ---- Meat Type: {_meatType} ");
    }
}