using Models;
namespace Factories;

public abstract class ProductFactory
{
    public abstract Product CreateProduct(string ProductType, string productType, string name, decimal price, int quantity, string expiry, bool inSeason, MeatType meatType);

}