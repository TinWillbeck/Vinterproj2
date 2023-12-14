public class Deck
{
    // ett deck består av en lista med kort
    List<Card> cards = new();

    Random generator = new Random();
    // kontruktorn skapar 14 kort i varje färg 
    public Deck()
    {
        // array med alla färger
        string[] colors = {"♣", "♥", "♠", "♦"};
        // loopen körs en gång för varje färg i arrayen colors
        foreach (var color in colors)
        {
            // loopen körs 14 gånger, skapar ett kort med ökande värde varje gång
            for (int i = 0; i < 13; i++)
            {
                Card c = new Card();
                c.color = color;
                c.value = i+1;
                // om kortets värde är över 11 sätts värdet till 10
                if (c.value > 11)
                {
                    c.value = 10;
                }
                // lägger till det skapade kortet i listan med kort
                cards.Add(c);
            }   
        }
    }

    // en metod för att skriva ut alla kort, använs inte i spelet
    public void PrintCards()
    {
        // skriver ut hur många kort som finns i listan
        Console.WriteLine(cards.Count);
        // skriver ut varje individuellt korts värde och färg
        for (int i = 0; i < cards.Count; i++)
        {
            Console.Write(cards[i].value);
            Console.WriteLine(cards[i].color);
        }
    }
    
    // en metod för att ta ett kort ur leken
    public Card Draw()
    {
        // slumpar ett kort
        int i = generator.Next(cards.Count);
        // lägger kortet i en tilfällig variabel
        Card c = cards[i];
        // tar ut kortet ur listan
        cards.Remove(cards[i]);
        // returnerar kortet
        return c;
    }
}
