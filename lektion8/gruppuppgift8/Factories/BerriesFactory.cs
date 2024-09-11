using Models;
namespace Factories;

public class BerriesFactory : ProductFactory
{
    public override Product CreateProduct(string ProductType, string productType, string name, decimal price, int quantity, string expiry, bool inSeason, MeatType meatType)
    {
        return new Berries(ProductType, name, price, quantity, inSeason);
    }
}