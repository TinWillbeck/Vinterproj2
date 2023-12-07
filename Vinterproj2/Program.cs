Console.OutputEncoding = System.Text.Encoding.UTF8;


Hand player = new();

Hand house = new();

// Deck deck = new();
// deck.PrintCards();
// Console.ReadLine();

Dictionary<string, Action> moves = new();

moves.Add("hit", player.Hit);
moves.Add("done", player.Done);

string action = "";

Console.WriteLine("Starting hand:");
player.printHand();
Console.WriteLine("Press enter to proceed");
Console.ReadLine();

// spel loopen körs så länge spelarens summa kort inte överstiger 21
while (player.handSum <=21 && action != "done")
{
    action = "";
    Console.Clear();
    Console.WriteLine("Make a move by writing hit or done");
    while (!moves.Keys.Contains(action))
    {
        action =  Console.ReadLine();
    }

    moves[action]();
    player.printHand();
    Console.WriteLine("Press enter to proceed");
    Console.ReadLine();

}

if(player.handSum > 21)
{
    Console.WriteLine("You lost;");
}

Console.WriteLine("House starting hand");
house.printHand();

Console.WriteLine("Press enter to proceed");
Console.ReadLine();
// loopen körs så länge husets summa kort är under 17 eller är under spelarens summa kort och spelarens summa kort är under 21
while (house.handSum <= 17 || house.handSum < player.handSum && player.handSum <= 21)
{
    Console.Clear();
    house.Hit();
    Console.WriteLine("---------House----------");
    house.printHand();
    Console.WriteLine("Press enter to proceed");

    Console.ReadLine();
}


if (house.handSum > 21)
{
    Console.WriteLine("House lost!");
}
else if (house.handSum > player.handSum)
{
    Console.WriteLine("House won!");
}
else
{
    Console.WriteLine("You won!");
}

Console.ReadLine();

//  && player.handSum <= 21