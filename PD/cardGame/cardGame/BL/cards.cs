using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGame.BL
{
    class cards
    {
        public int values;
        public int suits;
        public cards()
        {

        }
        public cards(int values, int suits)
        {
            this.values = values;
            this.suits = suits;
        }
        public int getValue()
        {
            return values;
        }
        public int getSuit()
        {
            return suits;
        }
        public String getSuitAsString()
        {
            if (values == 1)
            {
                return "Ace";
            }
            else if (values == 11)
            {
                return "Jack";
            }
            else if (values == 12)
            {
                return "Queen";
            }
            else if (values == 13)
            {
                return "King";
            }
            else
            {
                return values.ToString();
            }
        }
        public String getValueAsString()
        {
            if (suits == 1)
            {
                return "Clubs";
            }
            else if (suits == 2)
            {
                return "Diamonds";
            }
            else if (suits == 3)
            {
                return "Spades";
            }
            else
            {
                return "Heart";
            }
        }
        public String toString()
        {
            return getValueAsString() + " of " + getSuitAsString();
        }
    }
}
