using System;
using System.Collections.Generic;

class Deck {
    private List<Card> _Deck = new List<Card>();
    public List<Card> Cards {
        get {
            return _Deck;
        }
        protected set {
            _Deck = value;
        }
    }

    public Deck() {
        for (int i = 0; i < 14; i++)
            for (int j = 0; j < 6; j++) {
                if ((i > 12 && j < 4) || (i < 13 && j > 3))
                    continue;
                _Deck.Add(new Card(i, j));
            }
    }

    public Deck(List<Card> cards) {
        this.Cards = cards;
    }
}