using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGame.BL
{
    class deck
    {
        private int count;
        private cards[] Deck = new cards[52];
        public deck()
        {
            count = 0;
            for (int x = 1; x < 4; x++)
            {
                for (int y = 1; y <= 13; y++)
                {
                    Deck[count] = new cards(y, x);
                    count++;
                }
            }
        }
        public void shuffle()
        {
            System.Random rand = new Random();
            cards temp;
            for (int i = 0; i < 52; i++)
            {
                int num = rand.Next(0, 52);
                temp = Deck[num];
                Deck[num] = Deck[i];
                Deck[i] = temp;
            }
            count = 52;
        }
        public cards dealCard()
        {
            if (count > 0)
            {
                count--;
                return Deck[count];
            }
            else
            {
                return null;
            }
        }
        public int cardsLeft()
        {
            return count;
        }
    }
}
