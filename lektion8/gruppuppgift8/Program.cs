using Factories;
using Models;

public static class Program
{
    public static void Main()
    {
        Milk milk = new Milk("Milk", "Milk", 12.99m, 10, "2022-12-31");
        Berries berries = new Berries("Berries", "Berries", 45.50m, 20, true);
        DogFood dogFood = new DogFood("Dog Food", "Dog Food", 78.99m, 30, MeatType.Lamb);
        milk.DisplayInfo();
        berries.DisplayInfo();
        dogFood.DisplayInfo();
    }
}