using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //get and set for rank, which is the ace-king of the playing cards, and suit (club, diamond, spade, heart)
        public int Rank { get; set; }
        public int Suit { get; set; }

        //constructor for each card
        public Card(int rank, int suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }
}