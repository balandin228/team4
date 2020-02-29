using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace thegame.Model
{
    public class Game : IGame
    {
        private Card[,] field;

        public int Points { get; }

        public Game(IShuffler<Card> shu)
        {
            field = new Card[8, 4];
            var cards = Enumerable.Range(0, 16).Select(id => new Card() {PictureId = id});
        }


        public void FillInField(IEnumerable<Card> cards)
        {
            field = null;
        }

        public Card OpenedCard { get; private set; }
        public Card[,] OpenCell(Guid id)
        {
            throw new NotImplementedException();
        }

        public Card[,] MakeTurn(Guid id)
        {
            var card = FindCardById(id);
            OpenCard(card);
            Operate(card);

            return field;
        }

        private void Operate(Card card)
        {
            if (OpenedCard == null)
                OpenedCard = card;
            else
            {
                if (OpenedCard.PictureId == card.PictureId &&
                    OpenedCard.Id != card.Id)
                {
                    OpenedCard.State = Card.CardState.Removed;
                    card.State = Card.CardState.Removed;
                }
                else
                {
                    OpenedCard.State = Card.CardState.Closed;
                    card.State = Card.CardState.Closed;
                }

                OpenedCard = null;
            }
        }

        private static void OpenCard(Card card)
        {
            if (card.State == Card.CardState.Closed)
                card.State = Card.CardState.Opened;
        }

        private Card FindCardById(Guid id)
        {
            foreach(var card in field)
                if (card.Id == id)
                    return card;
            throw new Exception();
        }
    }
}