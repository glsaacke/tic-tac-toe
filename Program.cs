//MAIN***

System.Console.WriteLine("Welcome to tic-tac-toe!\n\nHit any key to start a new game");
Console.ReadKey();

DisplayBoard();

//***END

static void DisplayBoard(){
    Console.Clear();
    System.Console.WriteLine("___|___|___");
    System.Console.WriteLine("___|___|___");
    System.Console.WriteLine("   |   |   ");
}
