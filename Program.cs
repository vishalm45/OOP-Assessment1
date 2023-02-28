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
            Pack mypack = new Pack();

            Console.WriteLine("Initial pack: ");
            mypack.PrintPack();

            Console.WriteLine("\nShuffled pack (Fisher-Yates):");
            mypack.shuffleCardPack(1);
            mypack.PrintPack();

            Console.WriteLine("\nDealt one card:");
            Card dealtCard = mypack.dealCard();
            Console.WriteLine($"Dealt card: {dealtCard.Value}-{dealtCard.Suit}");

            Console.WriteLine("\nDealt 3 cards:");
            List<Card> dealtCards = mypack.dealCard(5);
            foreach (Card card in dealtCards)
            {
                Console.WriteLine($"Dealt card: {card.Value}-{card.Suit}");
            }

            Console.WriteLine("\nRemaining pack:");
            mypack.PrintPack();

            Console.ReadKey();
        }
    }
}
