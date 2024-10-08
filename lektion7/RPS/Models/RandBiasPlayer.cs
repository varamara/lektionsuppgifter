using RPS.Enums;
using RPS.Interfaces;

namespace RPS.Models;

public class RandBiasPlayer : IRpsPlayer
{
    private Random _random = new();

    public RpsMove GenerateRpsMove()
    {
        int choice = _random.Next(1, 101);
        if (choice > 80)
            return RpsMove.Scissor;
        else if (choice > 30)
            return RpsMove.Paper;
        else
            return RpsMove.Rock;
    }
}