using Models;
namespace Factories;

public class MilkFactory : ProductFactory
{
    public override Product CreateProduct(string productType, string name, decimal price, int quantity, params object[] extraParams)
    {
        string expiry = extraParams[0] as string;
        return new Milk(productType, name, price, quantity, expiry);
    }
}