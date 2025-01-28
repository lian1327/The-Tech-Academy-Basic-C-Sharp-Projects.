using System;
using CardGame;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine("Deck before shuffling:");
            deck.DisplayDeck();

            deck.Shuffle();
            Console.WriteLine("\nDeck after shuffling:");
            deck.DisplayDeck();

            Console.WriteLine($"\nDealing a card: {deck.Deal()}");
        }
    }
}
