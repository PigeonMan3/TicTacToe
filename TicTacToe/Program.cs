// Speler == X en computer == O
using TicTacToe;

string PositieInvoer;
bool Spelen = true;
int Status;

Grid grid = new Grid();
while (Spelen == true)
{
    Console.Clear();
    Status = grid.Controle();// 0 = bord is vol, 1 = gewonnen, -1 = verloren, 3 == nog geen resultaat
    Console.WriteLine(Status);
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
    Console.Clear() ;
    Console.WriteLine(grid.GridPrinten());
    Console.WriteLine("Nu zal de computer zijn zet doen !");
    //computer 
    
    
    

}
