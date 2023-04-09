// Speler == X en computer == O
using TicTacToe;

string PositieInvoer;
bool Spelen = true;
int Status;

Grid grid = new Grid();
while (Spelen == true)
{
    Console.Clear();
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
    Status = grid.Controle();// 0 = bord is vol, 1 = gewonnen, -1 = verloren, 3 == nog geen resultaat
    Console.Clear();
    switch(Status)
    {
        case 0:
            Console.WriteLine("Het raster is vol, niemand wint"); 
            Spelen = false;
            break;
        case 1:
            Console.WriteLine("Proficiat je bent gewonnen"); 
            Spelen = false;
            break ; 
        case -1:
            Console.WriteLine("Jammer, je bent verloren");
            Spelen = false;
            break;
    }




}
Console.WriteLine("Dankuwel om te spelen tot later !!");
Console.ReadLine();
