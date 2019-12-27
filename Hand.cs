using System;
using System.Collections.Generic;
class Hand
{

    List<Group> _Groups = new List<Group>();
    public List<Group> Groups
    {
        get
        {
            return _Groups;
        }
        set
        {
            _Groups = value;
        }
    }
    public Hand(ref Deck deck, int NumberOfCards)
    {
        Random random = new Random();
        List<Card> Cards = new List<Card>();

        for (int i = 0; i < NumberOfCards; i++)
        {
            int r = random.Next(deck.Cards.Count);
            // int r = Random.Range(deck.Cards.Count);

            Cards.Add(deck.Cards[r]);
            deck.Cards.RemoveAt(r);
        }

        SortHand(Cards);
    }

    public Hand(ref List<Deck> decks, int NumberOfCards)
    {
        Random random = new Random();
        List<Card> Cards = new List<Card>();

        for (int i = 0; i < NumberOfCards; i++)
        {
            int rDeck = random.Next(decks.Count);
            // int rDeck = Random.Range(0, decks.Count);
            int rCard = random.Next(decks[rDeck].Cards.Count);
            // int rCard = Random.Range(0, decks[rDeck].Cards.Count);

            Cards.Add(decks[rDeck].Cards[rCard]);
            decks[rDeck].Cards.RemoveAt(rCard);
        }

        SortHand(Cards);
    }

    public void SortHand(List<Card> Cards)
    {
        List<Card> TempGroup = new List<Card>();

        for (int i = 0; i < 5; i++)
        {
            foreach (Card card in Cards)
            {
                if (i < 4 && i == card.Suit)
                {
                    TempGroup.Add(card);
                }
                else if (i > 3 && card.Suit > 3)
                {
                    TempGroup.Add(card);
                }
            }

            for (int j = 0; j < TempGroup.Count - 1; j++)
            {
                for (int k = j + 1; k < TempGroup.Count; k++)
                {
                    if (TempGroup[j].Rank > TempGroup[k].Rank)
                    {
                        Card Temp;
                        Temp = TempGroup[j];
                        TempGroup[j] = TempGroup[k];
                        TempGroup[k] = Temp;
                    }
                }
            }

            _Groups.Add(new Group(TempGroup));
            TempGroup = new List<Card>();
        }
    }
}