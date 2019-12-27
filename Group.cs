using System;
using System.Collections.Generic;

class Group : Deck {
    private static List<string> _Status = new List<string>() {
        "First Life", "Second Life",
        "Pure Run", "Pure Set",
        "Impure Run", "Impure Set", 
        "Joker Set"
    };

    public string Status {
        get {
            return _Status[status];
        }
        set {}
    }

    private int status;

    public Group(List<Card> cards) : base(new List<Card>()) {
        this.Cards = cards;
    }
}