using StenSaxPase.Enums;
using StenSaxPase.Interfaces;
using StenSaxPase.Models;

IRpsPlayer player1 = new RandomRpsPlayer();

RpsMove move = player1.GenerateRpsMove();