using System;
using System.Collections.Generic;
using System.Linq;

namespace thegame.Model
{
    public static class Game
    {
        public static int[,] GenerateField(IShuffler shuffler, int width = 8, int height = 4)
        {
            if (width * height % 2 == 1)
                throw new ArgumentException();

            var ids = Enumerable.Range(1, width * height / 2);
            var cardsIds = ids.Concat(ids);
            cardsIds = shuffler.Shuffle(cardsIds);

            return ParseIdsToField(cardsIds, width, height);
        }

        private static int[,] ParseIdsToField(IEnumerable<int> arr, int width, int height)
        {
            var cardField = new int[width, height];
            var enumerator = arr.GetEnumerator();
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    cardField[x, y] = enumerator.Current;
                    enumerator.MoveNext();
                }
            }
            return cardField;
        }
    }
}