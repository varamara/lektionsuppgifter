using StenSaxPase.Enums;
using StenSaxPase.Interfaces;

namespace StenSaxPase.Models;

public class RandomRpsPlayer : IRpsPlayer
{

    private Random _random = new();

    public RpsMove GenerateRpsMove()
    {
        RpsMove choice = (RpsMove)_random.Next(0, 3);
        return choice;
    }
}