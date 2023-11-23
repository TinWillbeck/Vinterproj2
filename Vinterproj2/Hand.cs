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
        hand.Add(deck.Draw());
    }

    public void Done()
    {

    }

    public void printHand()
    {
        Console.WriteLine("----------Hand----------");
        Console.WriteLine("------------------------");
        for (int i = 0; i < hand.Count; i++)
        {
            Console.WriteLine(hand[i].value);
            Console.WriteLine(hand[i].color);
        }
        Console.WriteLine("------------------------");

    }
}
