using RPS.Enums;
using RPS.Interfaces;

namespace RPS.Models;

public class RandPlayer : IRpsPlayer
{
    private Random _random = new();

    public RpsMove GenerateRpsMove()
    {
        RpsMove choice = (RpsMove)_random.Next(0, 3);
        return choice;
    }
}