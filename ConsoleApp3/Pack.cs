using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{



    class Pack
    {
        //creates a list for the new pack which can be resized (unlike arrays)
        public static List<Card> newDeck = new List<Card>();

        public Pack()
        {
            //iterates over the ranks and suits to create a 4*13 card pack, 52 cards using new Card() constructor.

            {

                int[] ranks = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
                int[] suits = { 1, 2, 3, 4 };

                foreach (int suit in suits)
                {
                    foreach (int rank in ranks)
                    {
                        newDeck.Add(new Card(rank, suit));
                    }
                }

            }
        }

        //base for dealing
        public static int currentCard = 0;

        public static void shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            //Yates shuffle, picks a random card, adds to list then iterates through the list.
            if (typeOfShuffle == 1)
            {
                Random rnd = new Random();

                for (int n = newDeck.Count() - 1; n > 0; --n)
                {

                    int k = rnd.Next(n + 1);

                    Card temp = newDeck[n];
                    newDeck[n] = newDeck[k];
                    newDeck[k] = temp;

                }
                Console.WriteLine("Yates shuffled pack: " + newDeck);
            }
            // riffle shuffle.
            else if (typeOfShuffle == 2)
            {
                //creates a half way point for each array, splits the deck then adds one --> two --> one to simulate a ruffle.
                int half = newDeck.Count / 2;

                Card[] firstHalf = newDeck.Take(newDeck.Count / 2).ToArray();
                Card[] secondHalf = newDeck.Skip(newDeck.Count / 2).ToArray();
                List<Card> riffleDeck = new List<Card>();
                for (int i = 0; i < half; i++)
                {
                    riffleDeck.Add(firstHalf[i]);
                    riffleDeck.Add(secondHalf[i]);
                    newDeck = riffleDeck;
                }
            }
            else if (typeOfShuffle != 0)
            {
                Console.WriteLine("Error! Please use 0, 1 or 2 for shuffling.");
                }

        }
    
        public static Card deal()
        {
            //Deals one card
            Card card = newDeck[currentCard];
            Console.WriteLine("Current card is... " + card);
            currentCard++;
            return card;


        }
        //Deals the number of cards specified by 'amount'
        public static void dealCard(int amount)
        {
            //checks how many cards are left (currentcard) plus how many you want to draw against the pack size of 52.
            if (currentCard + amount > 51)
            {
                Console.WriteLine("Error: Not enough cards left in pack.");
                
            }

            else
            {
                Console.WriteLine("Dealing " + amount + " cards...");
                
                for (int i = 0; i < amount; i++)
                {
                    Card card = newDeck[currentCard];
                    currentCard++;
                    Console.WriteLine(card);

                }
            }
        }

    }
}
