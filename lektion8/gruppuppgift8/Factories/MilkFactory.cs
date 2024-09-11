using Models;
namespace Factories;

public class MilkFactory : ProductFactory
{
    public override Product CreateProduct(string ProductType, string productType, string name, decimal price, int quantity, string expiry, bool inSeason, MeatType meatType)
    {
        return new Milk(ProductType, name, price, quantity, expiry);
    }
}


