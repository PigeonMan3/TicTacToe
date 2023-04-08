// Speler == X en computer == O
using TicTacToe;

string PositieInvoer;
bool Spelen = true;

Grid grid = new Grid();
while (Spelen == true)
{
    Console.WriteLine(grid.GridPrinten());
    Console.WriteLine("In welk vakje Wil je uw X zetten ?");
    PositieInvoer = Console.ReadLine();
    grid.GridInvullenSpeler(PositieInvoer.Substring(0, 1), Convert.ToInt16(PositieInvoer.Substring(1, 1)));
}
