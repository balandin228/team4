using System;
using System.Collections.Generic;
using System.Linq;

namespace thegame.Model
{
    public class CardShuffler : IShuffler<Card>
    {
        private Random rnd;
        public CardShuffler()
        {
            rnd = new Random();
        }

        public IEnumerable<T> Shuffle<T>(IEnumerable<T> sequence)
        {
            return sequence
                .Select(obj => new {Number = rnd.Next(), Obj = obj})
                .OrderBy(x => x.Number)
                .Select(x => x.Obj);
        }
    }
}