using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cardGame.UI;
using cardGame.BL;

namespace cardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                option = CRUD.gameMenu();
                if (option == 1)
                {
                    bool gamerunning = true;
                    int score = 0;
                    deck obj = new deck();
                    obj.shuffle();
                    cards card1 = obj.dealCard();

                    while (gamerunning)
                    {
                        int remain_check = obj.cardsLeft();
                        cards card2 = obj.dealCard();
                        int card_Check = CRUD.remaining(card1, remain_check);
                        if (card_Check == 1)
                        {
                            if (card2.getValue() >= card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                CRUD.gameLose(card2, score, gamerunning);
                            }
                        }
                        if (card_Check == 2)
                        {
                            if (card2.getValue() < card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                CRUD.gameLose(card2, score, gamerunning);
                            }
                        }
                        if (obj.cardsLeft() == 0 && card2 == null)
                        {
                            CRUD.gamewin(gamerunning);
                            break;
                        }
                    }
                }
            }
            while (option != 2);
        }
    }
}
