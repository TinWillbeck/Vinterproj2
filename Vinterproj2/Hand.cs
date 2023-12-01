public class Hand
{

    List<Card> hand = new();
    public int handSum = 0;
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
        Console.WriteLine($"Final card sum: {handSum}");
    }

    public void printHand()
    {
        handSum = 0;
        Console.WriteLine("----------Hand----------");
        for (int i = 0; i < hand.Count; i++)
        {
            Console.Write($"{hand[i].value} ");
            Console.WriteLine(hand[i].color);
            handSum += hand[i].value;
        }
        Console.WriteLine($"Cards sum: {handSum}");
        Console.WriteLine("------------------------");
    }
    // private void handSumUppdate()
    // {
    //     handSum = 0;
    //     // Gå igenom hela handen
    //     // För varje kort
    //     // Lägg till det kortets värde till handSum


    //     handSum += card.value;
    // }
}
