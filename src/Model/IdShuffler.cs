using System;
using System.Collections.Generic;
using System.Linq;

namespace thegame.Model
{
    public class Shuffler : IShuffler
    {
        private readonly Random random;
        public Shuffler()
        {
            random = new Random();
        }

        public IEnumerable<T> Shuffle<T>(IEnumerable<T> sequence)
        {
            return sequence
                .Select(obj => new {Number = random.Next(), Obj = obj})
                .OrderBy(x => x.Number)
                .Select(x => x.Obj);
        }
    }
}