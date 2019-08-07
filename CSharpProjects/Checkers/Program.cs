using System;
using System.Collections.Generic;

public struct Position
{
    public int row { get; private set; }
    public int col { get; private set; }
    public Position(int row, int col)
    {
        this.row = row;
        this.col = col;
    }
}

public enum Color { White, Black }

class Program
{

    public static void Main(String[] args)
    {
        Game game = new Game();
        game.Start();
    }
}
