using System;
using System.Collections.Generic;

[Serializable]
public class DeckModel
{
    public DeliveryDeck deliveryDeck;
    public Deck discardDeck;
    public List<InGameDeck> inGameDecks = new List<InGameDeck>();
    public List<Deck> finishedDecks = new List<Deck>();

    public void PrepareDecks(IDecksListener decksListener)
    {
        deliveryDeck.Setup(decksListener);

        foreach (var gameDeck in inGameDecks)
            gameDeck.Setup(decksListener);


    }
}

