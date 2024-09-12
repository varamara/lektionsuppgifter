using Models;
namespace Factories;

public class BerriesFactory : ProductFactory
{
    public override Product CreateProduct(string productType, string name, decimal price, int quantity, params object[] extraParams)
    {
        bool inSeason = (bool)extraParams[0];
        return new Berries(productType, name, price, quantity, inSeason);
    }
}