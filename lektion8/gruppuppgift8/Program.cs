using Factories;
using Models;

public static class Program
{
    public static void Main()
    {
        ProductFactory milkFactory = new MilkFactory();
        Product oatly = milkFactory.CreateProduct("Milk", "Oatly", 12.99m, 10, "2022-12-31");
        oatly.DisplayInfo();

        BerriesFactory berriesFactory = new BerriesFactory();
        Product blueberries = berriesFactory.CreateProduct("Berries", "Blueberries", 45.50m, 20, true);
        blueberries.DisplayInfo();


        DogFoodFactory dogFoodFactory = new DogFoodFactory();
        Product voffVoff = dogFoodFactory.CreateProduct("Dog Food", "Voff voff", 78.99m, 30, MeatType.Lamb);
        voffVoff.DisplayInfo();
    }
}
