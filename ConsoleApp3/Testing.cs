using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack newDeck = new Pack();
            Pack.shuffleCardPack(1);
            Pack.shuffleCardPack(2);
            Pack.shuffleCardPack(0);
            Pack.shuffleCardPack(4);

            Pack.deal();
            Pack.dealCard(22);
        }
    }
}