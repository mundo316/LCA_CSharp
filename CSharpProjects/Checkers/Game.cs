using System;
namespace Checkers
{
    public class Game
    {
        private Board board;
        public Game()
        {
            this.board = new Board();
        }

        private bool CheckForWin()
        {
            // .. if all opposing colored checkers are gone??
            //all (whatever char value is) = 0??
            // || if list doesnt contain (whatever char value is)??
            if (this.team checkers = null)
            {
                 
            }
        }

        public void Start(Color player)
        {
            // ...black checkers go first
            this.team;
        }

        public bool IsLegalMove(Color player, Position src, Position dest)
        {
            // ...can only move diagonal one space forward, two spaces if jumping, and borwards or backwards and can combo if king

        }

        public bool IsCapture(Position src, Position dest)
        {
            // ...if jumped by opposite piece
            // (if space has any kind of opposing value)
        }

        public Checker GetCaptureChecker(Position src, Position dest)
        {
            // ..do while{} when jumping opposite piece event occurs??

        }

        public Position ProcessInput()
        {
            //ask user
            Console.WriteLine($"{this.team}'s turn.");
            Console.WriteLine("Select Row);
    
            Console.ReadLine() = Position.row;
            Console.WriteLine("Select Column");
            Console.ReadLine() = Position.col;

            //getchecker()

            //movechecker()
            // ...islegalmove()
            //movechecker()
            //iscapture()
            //if iscapture(true)
            // getcapturedchecker(()
            //checkforwin
            //switchturns


        }

        public void DrawBoard()
        {
            String[][] grid = new String[8][];
            for (int r = 0; r < 8; r++)
            {
                grid[r] = new String[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in board.checkers)
            {
                grid[c.position.row][c.position.col] = c.symbol;
            }

            Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int r = 0; r < 8; r++)
            {
                Console.Write(r);
                for (int c = 0; c < 8; c++)
                {
                    Console.Write(" {0}", grid[r][c]);
                }
                Console.WriteLine();
            }
        }


    }
}
