using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
        }
    }
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation

        public int Rank { get; set; }
        public int Suit { get; set; }

        public Card(int rank, int suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }




    class Pack
    {
        List<Card> pack = new List<Card>();
        public static int currentCard = 0;


        public Pack()
        {

            int[] ranks = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int[] suits = { 1, 2, 3, 4 };

            foreach (int suit in suits)
            {
                foreach (int rank in ranks)
                {
                    pack.Add(new Card(rank, suit));
                }
            }

            foreach (Card card in pack)
            {
                Console.WriteLine(card);
            }
            //Initialise the card pack here
        }

        public void shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                Random rnd = new Random();

                for (int n = pack.Count - 1; n > 0; --n)
                {

                    int k = rnd.Next(n + 1);

                    Card temp = pack[n];
                    pack[n] = pack[k];
                    pack[k] = temp;

                }
            }
            else
            {
                
            }
        }


        public static Card deal()
        {
            //Deals one card
            Card card = pack[currentCard];
            return card;


        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            for (int i = 0; i < amount; i++)
            {

            }
        }
    }

}