
public class Deck
{
    List<Card> cards = new();

    Random generator = new Random();
    public Deck()
    {
        string[] colors = {"clubs", "hearts", "spades", "diamonds"};
        foreach (var color in colors)
        {
            for (int i = 0; i < 13; i++)
            {
                Card c1 = new Card();
                c1.color = color;
                c1.value = i+1;
                cards.Add(c1);
            }   
        }
    }

    public void PrintCards()
    {
        Console.WriteLine(cards.Count);
        for (int i = 0; i < cards.Count; i++)
        {
            Console.WriteLine(cards[i].value);
            Console.WriteLine(cards[i].color);
        }
    }
    
    public Card Draw()
    {
        int i = generator.Next(cards.Count);

        Card c = cards[i];
        Console.WriteLine(c.value);
        Console.WriteLine(c.color);
        cards.Remove(cards[i]);
        return c;
    }
}
