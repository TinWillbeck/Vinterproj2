Console.OutputEncoding = System.Text.Encoding.UTF8;

// en string för att starta om
string restart = "restart";

// Loopen skriver ut en välkomsttext och kör sedan GameLoop, efter det får man alternativet att starta om
while (restart == "restart")
{
    Console.WriteLine("Welcome to BlackJack");
    GameLoop game = new();
    Console.WriteLine("To restart, write restart!");
    restart = Console.ReadLine();
    Console.Clear();
}
