using System;

namespace thegame.Model
{
    public class Card
    {
        public enum CardState
        {
            Closed,
            Opened,
            Removed
        }

        public CardState State { get; set; }

        public int PictureId { get; set; }
        public Guid Id { get; set; }
    }
}