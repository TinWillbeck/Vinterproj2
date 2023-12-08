public class Hand
{
    // hand innehåller en lista med kort, en variabel som håller koll på summan kort och ett deck
    List<Card> hand = new();
    public int handSum = 0;
    Deck deck = new();
    // handen startar med två kort
    public Hand()
    {
        hand.Add(deck.Draw());
        hand.Add(deck.Draw());
        
    }

    // metoden lägger till ett kort
    public void Hit()
    {
        hand.Add(deck.Draw());
    }

    
    public void Split()
    {
        // kolla vilka kort som finns i listan hand
        // separera korten i två olika listor
        // vet inte riktigt hur draget fungerar i riktig blackjack
    }

    // metoden skriver ut summan kort
    public void Done()
    {
        Console.WriteLine($"Final card sum: {handSum}");
        
    }

    // metoden skriver ut handen och uppdaterar summan kort
    public void printHand()
    {
        
        handSum = 0;
        Console.WriteLine("----------Hand----------");
        // skriver ut alla korts värde och färg samt ökar summan kort med värdet för det kortet som skrivs ut
        for (int i = 0; i < hand.Count; i++)
        {
            Console.Write($"{hand[i].value} ");
            Console.WriteLine(hand[i].color);
            handSum += hand[i].value;
        }
        Console.WriteLine($"Cards sum: {handSum}");
        Console.WriteLine("------------------------");
    }


}
