using Models;
namespace Factories;

public abstract class ProductFactory
{
    public abstract Product CreateProduct(string productType, string name, decimal price, int quantity, params object[] extraParams);
}

// params är ett nyckelord i C# som tillåter att en metod kan ta emot ett variabelt antal argument, 
// och dessa argument skickas som en array till metoden. 
// Detta är användbart när du inte vet exakt hur många parametrar du kommer att behöva skicka till en metod på förhand. 
// Du kan skicka in noll eller fler parametrar av den angivna typen (i ditt fall object[], 
// vilket betyder att du kan skicka in vilken typ av objekt som helst).