using System;

namespace thegame.Model
{
    public interface IGame
    {
        int Points { get; }
        Card OpenedCard { get; }

        Card[,] MakeTurn(Guid id);
    }
}