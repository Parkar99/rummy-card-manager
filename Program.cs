using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List<Card> deck = GenerateDeck();
        Deck deck = new Deck();
        Hand hand = new Hand(ref deck, 13);
        // hand.SortHand();

        foreach (Card card in deck.Cards)
            Console.WriteLine(card.Name);
        
        Console.WriteLine("Cards: " + deck.Cards.Count);
        Console.WriteLine();

        // foreach (Card card in hand.Cards)
        //     Console.WriteLine(card.Name);

        Console.WriteLine();
        int count = 1;

        foreach (Group d in hand.Groups) {
            foreach (Card c in d.Cards)
                Console.WriteLine(count++ + " " + c.Name);

        Console.WriteLine();
        }
    }
}