﻿using System;

namespace Chap10CardLib
{
    public class Deck
    {
        private Card[] cards;

        public Deck()
        {
            cards = new Card[52];
            var suitLength = Enum.GetNames(typeof(Suit)).Length;

            for (int suitVal = 0; suitVal < suitLength; suitVal++)
            {
                for(int rankVal=1; rankVal < 14; rankVal++ )
                {
                   cards[suitVal * 13 + rankVal - 1] = new  Card( (Suit) suitVal, (Rank) rankVal);
                }
            }
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                return cards[cardNum];
            }
            else
            {
                throw (new System.ArgumentOutOfRangeException(nameof(cardNum), cardNum, "value muste be between 0 and 51"));
            }
        }

        public void Shuffle()
        {
            Card[] newDeck = new Card[52];
            bool[] assigned = new bool[newDeck.Length];
            
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    destCard = sourceGen.Next(52);
                    if (assigned[destCard] == false)
                        foundCard = true;
                }

                assigned[destCard] = true;
                newDeck[destCard] = cards[i];
            }

            newDeck.CopyTo(cards, 0);
        }
    }
}