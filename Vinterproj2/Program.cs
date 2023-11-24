Console.OutputEncoding = System.Text.Encoding.UTF8;


Hand player = new();

Hand house = new();



Dictionary<string, Action> moves = new();

moves.Add("hit", player.Hit);
moves.Add("done", player.Done);

string action = "";

Console.WriteLine("Starting hand:");
player.printHand();
Console.WriteLine("Press enter to proceed");
Console.ReadLine();
while (player.handSum <=21)
{
    Console.Clear();
    Console.WriteLine("Make a move by writing hit or done");
    while (!moves.Keys.Contains(action))
    {
        action =  Console.ReadLine();
    }

    moves[action]();
    player.printHand();
}

Console.ReadLine();