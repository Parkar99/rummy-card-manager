using System;
using System.Collections.Generic;
class Hand : Deck {

    List<Deck> _Groups = new List<Deck>();
    public List<Groupg> Groups {
        get {
            return _Groups;
        }
        private set {
            _Groups = value;
        }
    }
    public Hand(ref Deck deck, int NumberOfCards) : base(new List<Card>()) {
        Random random = new Random();

        for (int i = 0; i < NumberOfCards; i++) {
            int r = random.Next(deck.Cards.Count);
            // int r = Random.Range(deck.Cards.Count);

            this.Cards.Add(deck.Cards[r]);
            deck.Cards.RemoveAt(r);
        }
    }

    public Hand(ref List<Deck> decks, int NumberOfCards) : base(new List<Card>()) {
        Random random = new Random();

        for (int i = 0; i < NumberOfCards; i++) {
            int rDeck = random.Next(decks.Count);
            // int rDeck = Random.Range(0, decks.Count);
            int rCard = random.Next(decks[rDeck].Cards.Count);
            // int rCard = Random.Range(0, decks[rDeck].Cards.Count);

            this.Cards.Add(decks[rDeck].Cards[rCard]);
            decks[rDeck].Cards.RemoveAt(rCard);
        }
    }

    public void SortHand() {
        List<Card> TempGroup = new List<Card>();

        for (int i = 0; i < 5; i++) {
            foreach (Card card in this.Cards) {
                if (i < 4 && i == card.Suit) {
                    TempGroup.Add(card);
                } else if (i > 3 && card.Suit > 3) {
                    TempGroup.Add(card);
                }
            }

            for (int j = 0; j < TempGroup.Count - 1; j++) {
                for (int k = j + 1; k < TempGroup.Count; k++) {
                    if (TempGroup[j].Rank > TempGroup[k].Rank) {
                        Card Temp;
                        Temp = TempGroup[j];
                        TempGroup[j] = TempGroup[k];
                        TempGroup[k] = Temp;
                    }
                }
            }

            _Groups.Add(new Deck(TempGroup));
            TempGroup = new List<Card>();
        }
    }
}