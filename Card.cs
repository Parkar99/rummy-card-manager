using System;
using System.Collections.Generic;

class Card {

    private static List<string> _SuitList = new List<string>() { "spades", "clubs", "diamonds", "hearts", "black", "red" };
    private static List<string> _RankList = new List<string>() {
        "ace", "2", "3", "4",
        "5", "6", "7", "8",
        "9", "10", "jack", "queen", "king", "joker"
    };
    public string Name {
        get {
            if (_RankList[Rank] == "joker")
                return _SuitList[Suit] + "_" + _RankList[Rank];
            else
                return _RankList[Rank] + "_of_" + _SuitList[Suit];
        }
        private set {}
    }
    public int Rank { get; private set; }
    public int Suit { get; private set; }

    public Card(int Rank, int Suit) {
        if ((Rank > 12 && Suit < 4) || (Rank < 13 && Suit > 3))
            throw new System.Exception("Card does not exist: rank = " + Rank + ", suit = " + Suit);

        if (!(Rank < 0) && !(Rank > 13))
            this.Rank = Rank;
        else
            throw new System.Exception("Invalid rank: " + Rank);

        if (!(Suit < 0) && !(Suit > 5))
            this.Suit = Suit;
        else throw new System.Exception("invalid suit: " + Suit);
    }
}