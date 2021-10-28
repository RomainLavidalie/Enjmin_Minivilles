﻿namespace DefaultNamespace
{
    public class Piles
    {
        private int CardType;
        private int PileSize;

        void Piles(Cards card, int size)
        {
            CardType = card.CardType;
            PileSize = size;
        }

        void AddCard(Cards card)
        {
            ++PileSize;
        }
        
        void RemoveCard(Cards card)
        {
            --PileSize;
        }
    }
}