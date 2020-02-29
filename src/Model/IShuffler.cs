using System.Collections.Generic;
using System.Linq;

namespace thegame.Model
{
    public interface IShuffler
    {
        IEnumerable<T> Shuffle<T>(IEnumerable<T> obj);
    }
}