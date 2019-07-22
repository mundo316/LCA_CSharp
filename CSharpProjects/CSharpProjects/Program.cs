using System;
using System.Collections.Generic;

namespace TowersofHanoi
{
    class MainClass
    {
        static Dictionary<string, Stack<int>> Towers = new Dictionary<string, Stack<int>>();
        //call upon constructed methods to run game
        public static void Main(string[] args)
        {
            Console.WriteLine("Towers of Hanoi");
            Console.WriteLine("Objective: Move the entire stack to row C without placing a bigger number onto a smaller number.");

            StartingBoard();
            
            while (Towers["C"].Count != 4)
            {
                Printboard();
                Gamemove();

            }

            Console.WriteLine("Congratulations! You Win!");
           
        }
        public static void StartingBoard() //starting board
        {
            Towers.Add("A", new Stack<int>());
            Towers.Add("B", new Stack<int>());
            Towers.Add("C", new Stack<int>());

            Towers["A"].Push(4);
            Towers["A"].Push(3);
            Towers["A"].Push(2);
            Towers["A"].Push(1);
        }

        //game display
        public static void Printboard()
        {
            foreach (var item in Towers.Keys)
            {
                int[] arrtower = Towers[item].ToArray();
                Console.Write(item + "| ");
                for(int i =arrtower.Length-1;i>=0;i--)
                {
                    Console.Write($"{arrtower[i]} ");
                }
                Console.WriteLine();
            }   
        }
        public static bool Rules(string from, string to)
        {
            //checks for illegal moves, cant move on top of a smaller block
            if (Towers[to].Count == 0  || Towers[to].Peek() > Towers[from].Peek())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //structure for processing each turn
        public static void Gamemove()
        {
            Console.WriteLine("Select the stack to move from.");
            string fromstack = Console.ReadLine().ToUpper();

            Console.WriteLine("Select the stack to move to.");
            string tostack = Console.ReadLine().ToUpper();

            if (Rules(fromstack, tostack))
            {
                Towers[tostack].Push(Towers[fromstack].Peek());
                Towers[fromstack].Pop();

            }

        }
    }
    


}
