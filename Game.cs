namespace tic_tac_toe
{
    public class Game
    {
        private bool checkWin;
        static public bool[] playerSpaces = new bool[9];
        static public bool[] comSpaces = new bool[9];

        public Game(bool checkWin){
            this.checkWin = checkWin;
        }

        public void DisplayBoard(){ //TODO update display based on array data
            Console.Clear();
            System.Console.WriteLine("  A   B   C");
            System.Console.WriteLine("1 ___|___|___");
            System.Console.WriteLine("2 ___|___|___");
            System.Console.WriteLine("3    |   |   ");
        }

        public void PlayerTurn(){
            System.Console.WriteLine("\nEnter your move");
            string userMove = Console.ReadLine();
        }

        public void ComTurn(){

        }

        private void UpdateArray(string coordinates){
            
        }

        public bool GetCheckWin(){
            return checkWin;
        }

        public void ToggleCheckWin(bool checkWin){
            checkWin = !checkWin;
        }


    }
}