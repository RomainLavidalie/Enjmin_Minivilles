using System;
using System.Collections.Generic;
namespace Enjmin_Minivilles_GFX
{
    public class Piles
    {
        private string CardType;
        private int PileSize;

        public Piles(Cards card, int size)
        {
            CardType = card.cardName;
            PileSize = size;
        }

        void AddCard(Cards card)
        {
            ++PileSize;
        }
        
        public void RemoveCard(Cards card)
        {
            --PileSize;
        }
    }
}