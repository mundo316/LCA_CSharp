using System;
using System.Collections.Generic;
namespace Checkers
{
    public class Board
    {
        public List<Checker> checkers;

        public Board()
        {
            checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                    checkers.Add(c);
                }
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.Black, 5 + r, (r) % 2 + i);
                    checkers.Add(c);
                }
            }
        }

        public Checker GetChecker(Position pos)
        {
            foreach (Checker c in checkers)
            {//fill in blanks
                if (c.Position.Row == (_______) && c.Position.Column == (______))
                {
                    return c;
                }
            }
        }

        public void RemoveChecker(Checker checker)
        {
            if (checker != null)
            {
                checkers.Remove(checker);
            }
        }

        public void MoveChecker(Checker checker, Position dest)
        {
            // if islegalmove() is true when move occurs
            //cw(checker) @ new space
            //remove old checker @ old space
            if (IsLegalMove())
            {
                Checker c = new Checker(!Color.Team , new Position());
                checkers.Remove(Checker.);
            }
            //else ask to input legal move
            else
            {
                Console.WriteLine("ERROR. PLEASE SELECT ANOTHER SPACE.");
            }
        }

    }
}