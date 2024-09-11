using Models;
namespace Factories;

public class DogFoodFactory : ProductFactory
{
    public override Product CreateProduct(string ProductType, string productType, string name, decimal price, int quantity, string expiry, bool inSeason, MeatType meatType)
    {
        return new DogFood(ProductType, name, price, quantity, meatType);
    }
}
