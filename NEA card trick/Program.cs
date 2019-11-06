using System;
using System.Collections.Generic;

namespace NEA_card_trick
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[,] Piles = new string[3, 7];
            string[] Houses = new string[3] { "CLUBS", "HEARTS", "SPADES" };
            List<string> Deck = new List<string>();
            //for (int i = 1; i <= 21; i++) Deck.Add(string.Format("{0} of {1}", i % 21, Houses[]);
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                }
            }
        }
    }
}
