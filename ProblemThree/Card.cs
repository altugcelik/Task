using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProblemThree.Enums;

namespace ProblemThree
{
    public class Card
    {
        public CardSuit CardSuit { get; private set; }
        public int CardValue { get; private set; }

        public Card(CardSuit cardSuit, int cardValue)
        {
            CardSuit = cardSuit;
            CardValue = cardValue;
        }
    }
}
