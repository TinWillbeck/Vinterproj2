public class Deck
{
    List<Card> cards = new();

    public Deck()
    {
        string[] colors = {"clubs", "hearts", "spades", "diamonds"};
        foreach (var colos in colors)
        {

            for (int i = 0; i < 13; i++)
            {
                Card c1 = new Card();
                cards.Add(c1);
            }
            
        }


    }
}
