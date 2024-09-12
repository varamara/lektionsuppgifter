namespace Models;

public class Berries : Product
{
    //Protected innebär att genskapen/fältet kan nås inom klassen 
    //där det är deklarerat och i alla underklasser som ärver från den klassen.
    //Användbart om vi förväntas skapa underklasser av ex berries

    protected bool _inSeason = false;

    public Berries(string ProductType, string name, decimal price, int quantity, bool inSeason) : base(ProductType, name, price, quantity)
    {
        _inSeason = inSeason;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{Name} ---- {Price}kr ---- Qnt: {Quantity} ---- In season: {_inSeason} ");
    }
}