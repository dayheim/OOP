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
        public static List<Card> pack = new List<Card>();
        
        
        


        public Pack()

        //iterates over the ranks and suits to create a 4*13 card pack, 52 cards.
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

            //displays each card unshuffled.
            foreach (Card card in pack)
            {
                Console.WriteLine(card);
            }
            //Initialise the card pack here
        }
        public static int currentCard = 0;

        public void shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            //Yates shuffle
            {
                Random rnd = new Random();

                for (int n = pack.Count() - 1; n > 0; --n)
                {

                    int k = rnd.Next(n + 1);

                    Card temp = pack[n];
                    pack[n] = pack[k];
                    pack[k] = temp;

                }
                // riffle shuffle.
            {
                    int half = pack.Count / 2;

                    for (int i = 0; i < half; i++)
                    {

                    }
            }

            }
        }

            public static Card deal()
            {
                //Deals one card
                Card card = pack[currentCard];
                currentCard++;
                return card;


            }
            public static void dealCard(int amount)
            {
            if (currentCard < amount)
            {
                Console.WriteLine("Error: Not enough cards left in pack. Printing remainder instead...");
            }
                //Deals the number of cards specified by 'amount'
               
            for (int i = 0; i < amount; i++)
             {
                Card card = pack[currentCard];
                currentCard++;
                Console.WriteLine(card);
            }
            }
        }

    }
