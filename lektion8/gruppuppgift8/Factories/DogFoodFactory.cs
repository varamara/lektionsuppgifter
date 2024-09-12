using Models;
namespace Factories;

public class DogFoodFactory : ProductFactory
{
    public override Product CreateProduct(string productType, string name, decimal price, int quantity, params object[] extraParams)
    {
        MeatType meatType = (MeatType)extraParams[0];
        return new DogFood(productType, name, price, quantity, meatType);
    }
}
