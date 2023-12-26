//MAIN***

bool checkWin = false;

int menuInput = MainMenu();

while(menuInput != 3){
    MenuLogic(menuInput);
    menuInput = MainMenu();
}

//***END

static int MainMenu(){
    Console.Clear();
    System.Console.WriteLine("Welcome to tic-tac-toe!\n\n1. Instructions\n2. Start new game\n3. Exit");
    int check = 0;
    int menuInput = -1;

    while(check == 0){
        try{
            menuInput = int.Parse(Console.ReadLine());
            check = 1;
        }
        catch{
            Error("Please enter a number from above");
        }
    }
    return menuInput;
}

static void MenuLogic(int menuInput){
    if(menuInput == 1){
        DisplayInstructions();
    }
    else if(menuInput == 2){
        RunGame();
    }
}

static void DisplayInstructions(){
    Console.Clear();
    System.Console.WriteLine("Tic-tac-toe game instructions");
    System.Console.WriteLine("_______________________________________________________________\n\n");
    System.Console.WriteLine("The program will randomly decide if you or the CPU goes first");
    System.Console.WriteLine("On your turn, enter the coordinates of the space you want to play (ex: A1, B1, C2)");
    System.Console.WriteLine("Take turns playing spaces until someone gets three in a row or all spaces are filled\n\n");
    System.Console.WriteLine("Press any key to return");
    Console.ReadKey();
}

static void RunGame(bool checkWin){
    while(checkWin == false){
        
    }
}

static void DisplayBoard(){
    Console.Clear();
    System.Console.WriteLine("  A   B   C");
    System.Console.WriteLine("1 ___|___|___");
    System.Console.WriteLine("2 ___|___|___");
    System.Console.WriteLine("3    |   |   ");
}

static void Error(string message){
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine("Error: " + message);
    Console.ResetColor();
}
