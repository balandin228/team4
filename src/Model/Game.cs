using System.Drawing;

namespace thegame.Model
{
    public class Game
    {
        private ICard[,] field;

        public Game()
        {
            field = new ICard[8, 4];
        }
    }
}