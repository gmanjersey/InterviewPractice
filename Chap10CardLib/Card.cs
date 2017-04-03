using System;

namespace Chap10CardLib
{
    [Serializable]
    public class Card
    {
       public readonly Suit suit;
       public readonly Rank rank;

        
        private Card() { }
        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }
        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }
    }
}