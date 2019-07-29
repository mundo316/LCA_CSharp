using System;

namespace TicTacToe
{
    class Program
    {
        public static bool playerTurn = true;
  
        public static string[][] board = {
            
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        
        public static void Main()
        {
            do
            {
                Console.WriteLine("---------------");
                DrawBoard();
                Console.WriteLine("---------------");
                GetInput();
                Console.WriteLine("---------------");
                playerTurn = !playerTurn;

            } while (!CheckForWin() && !CheckForTie());

            Console.WriteLine("GAME OVER!");
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            //kept returning "player true" || "player false" this fixed the problem
            if (playerTurn)
            {
                Console.WriteLine("PLAYER X");
            }

            else
            {
                Console.WriteLine("PLAYER O");
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            PlaceMark(row, column);
            Console.Clear();

        }

        public static void PlaceMark(int row, int column)
        {
            //check to see if current space is empty
            if (playerTurn)
            {
                board[row][column] = "X";
            }
            else
            {
                board[row][column] = "O";
            }
        }

        public static bool CheckForWin()
        {
            if (HorizontalWin() || VerticalWin() || DiagonalWin())
            {
                return true;
            }
            return false;
        }

        public static bool CheckForTie()
        {
            //checks to see if any spaces are empty
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (board[i][y] == " ")
                    { 
                        return false;
                    }
                }
            }
            Console.WriteLine("GAME OVER! IT IS A TIE");
            return true;
        }

        public static bool HorizontalWin()
        {
            if (board[0][0]=="X" && board[0][1]=="X" && board[0][2] == "X")
            {
                return true;
            }
            else if (board[1][0] == "X" && board[1][1] == "X" && board[1][2] == "X")
            {
                return true;
            }
            else if (board[2][0] == "X" && board[2][1] == "X" && board[2][2] == "X")
            {
                return true;
            }

            else if (board[0][0] == "O" && board[0][1] == "O" && board[0][2] == "O")
            {
                return true;
            }
            else if (board[1][0] == "O" && board[1][1] == "O" && board[1][2] == "O")
            {
                return true;
            }
            else if (board[2][0] == "O" && board[2][1] == "O" && board[2][2] == "O")
            {
                return true;
            }
                return false;
        }

        public static bool VerticalWin()
        {
            if (board[0][0] == "X" && board[1][0] == "X" && board[2][0] == "X")
            {
                return true;
            }
            else if (board[0][1] == "X" && board[1][1] == "X" && board[2][1] == "X")
            {
                return true;
            }
            else if (board[0][2] == "X" && board[1][2] == "X" && board[2][2] == "X")
            {
                return true;
            }
            else if (board[0][0] == "O" && board[1][0] == "O" && board[2][0] == "O")
            {
                return true;
            }
            else if (board[0][1] == "O" && board[1][1] == "O" && board[2][1] == "O")
            {
                return true;
            }
            else if (board[0][2] == "O" && board[1][2] == "O" && board[2][2] == "O")
            {
                return true;
            }    
            return false;
        }

        public static bool DiagonalWin()
        {
            if (board[0][0] == "X" && board[1][1] == "X" && board[2][2] == "X")
            {
                return true;
            }
            else if (board[0][2] == "X" && board[1][1] == "X" && board[2][0] == "X")
            {
                return true;
            }
            else if (board[0][0] == "O" && board[1][1] == "O" && board[2][2] == "O")
            {
                return true;
            }
            else if (board[0][2] == "O" && board[1][1] == "O" && board[2][0] == "O")
            {
                return true;
            }
            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
