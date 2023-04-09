// Speler == X en computer == O
using TicTacToe;

string PositieInvoer;
bool Spelen = true;

Grid grid = new Grid();
while (Spelen == true)
{
    Console.Clear();
    Console.WriteLine(grid.Controle());
    Console.WriteLine(grid.GridPrinten());
    Console.WriteLine("In welk vakje Wil je uw X zetten ?");
    PositieInvoer = Console.ReadLine();
    try
    {
        grid.GridInvullenSpeler(PositieInvoer.Substring(0, 1), Convert.ToInt16(PositieInvoer.Substring(1, 1)));
    }
    catch 
    {
        Console.WriteLine("Verkeerde Input");
        Console.ReadLine();
    }
    
}
