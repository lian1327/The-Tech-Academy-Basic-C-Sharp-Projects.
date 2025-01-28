using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Deck
    {
        private List<Card> cards;

        // Constructor to initialize the deck
        public Deck()
        {
            cards = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = 
            { 
                "2", "3", "4", "5", "6", "7", "8", "9", "10", 
                "Jack", "Queen", "King", "Ace" 
            };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        // Method to shuffle the deck
        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        // Method to deal a card from the deck
        public Card Deal()
        {
            if (cards.Count > 0)
            {
                Card dealtCard = cards[0];
                cards.RemoveAt(0);
                return dealtCard;
            }
            else
            {
                throw new InvalidOperationException("No cards left to deal.");
            }
        }

        // Method to display the deck
        public void DisplayDeck()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
