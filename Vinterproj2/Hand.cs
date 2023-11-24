public class Hand
{

    List<Card> hand = new();
    public int handSum = 0;
    Deck deck = new();
    public Hand()
    {
        hand.Add(deck.Draw());
        hand.Add(deck.Draw());
        handSum += 
    }

    public void Hit()
    {
        hand.Add(deck.Draw());
    }

    public void Done()
    {
        Console.WriteLine($"Final card sum: {handSum}");
    }

    public void printHand()
    {
        Console.WriteLine("----------Hand----------");
        for (int i = 0; i < hand.Count; i++)
        {
            Console.Write($"{hand[i].value} ");
            Console.WriteLine(hand[i].color);
        }
        Console.WriteLine($"Cards sum: {handSum}");
        Console.WriteLine("------------------------");

    }
}
