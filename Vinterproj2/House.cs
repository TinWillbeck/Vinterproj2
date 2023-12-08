public class House : Hand
{
    // Metod för när huset kör sin runda efter att spelaren är klar
    public void HouseTurn(Hand player)
    {
        // loopen körs så länge husets summa kort är under 17 eller är under spelarens summa kort och spelarens summa kort är under 21
        while (handSum <= 17 || handSum < player.handSum && player.handSum <= 21)
        {
            Console.Clear();
            Hit();
            Console.WriteLine("---------House----------");
            printHand();
            Console.WriteLine("Press enter to proceed");

            Console.ReadLine();
        }
    }
    // Metod för att kolla vem som vann
    public void CheckWinner(Hand player)
    {
        // om huset får över 21 förlorar huset
        if (handSum > 21)
        {
            Console.WriteLine("House lost!");
        }
        // om huset får högre summa än spelaren vinner huset
        else if (handSum > player.handSum)
        {
        Console.WriteLine("House won!");
        }
        // om spelaren får högre summa än huset vinner spelaren
        else
        {
        Console.WriteLine("You won!");
        }
    }
}
