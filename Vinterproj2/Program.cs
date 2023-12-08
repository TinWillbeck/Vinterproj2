Console.OutputEncoding = System.Text.Encoding.UTF8;

// Skapar en spelare och husets hand, huset är en spelare med extra funktionalitet
Hand player = new();
House house = new();

// Skapa en dictionary med drag för att slippa antar if satser
Dictionary<string, Action> moves = new();
moves.Add("hit", player.Hit);
moves.Add("done", player.Done);

string action = "";

// Intro text
Console.WriteLine("Starting hand:");
player.printHand();
Console.WriteLine("Press enter to proceed");
Console.ReadLine();

// spel loopen körs så länge spelarens summa kort inte överstiger 21
while (player.handSum <=21 && action != "done")
{
    // Nollställer action 
    action = "";
    Console.Clear();
    Console.WriteLine("Make a move by writing hit or done");
    // loopen körs när man skriver ett ord som finns med i dictionaryn moves
    while (!moves.Keys.Contains(action))
    {
        // sätter variabeln action till det man skrev in
        action =  Console.ReadLine();
    }

    // utför action
    moves[action]();
    player.printHand();
    Console.WriteLine("Press enter to proceed");
    Console.ReadLine();

}

// berättar för spelaren att den har förlorat om kortsumman är över 21
if(player.handSum > 21)
{
    Console.WriteLine("You lost;");
}
// om spelaren får exakt 21 så vinner den
else if(player.handSum == 21)
{
    Console.WriteLine("You Won!");
}
// om spelaren inte fått för många kort körs husets runda
else
{
    Console.WriteLine("House starting hand");
    house.printHand();

    Console.WriteLine("Press enter to proceed");
    Console.ReadLine();
    Console.Clear();

    house.HouseTurn(player);
    house.CheckWinner(player);
}

Console.ReadLine();
