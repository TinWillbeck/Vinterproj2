public class Hand
{

    List<Card> hand = new();
    Deck deck = new();
    public Hand()
    {

        hand.Add(deck.Draw());
        hand.Add(deck.Draw());
        
    }

    public void Hit()
    {
        
    }
}
