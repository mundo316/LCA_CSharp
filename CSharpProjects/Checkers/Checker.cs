using System;
namespace Checkers
{
    public class Checker
    {
        public String symbol { get; private set; }
        public Color team { get; private set; }
        public Position position { get; set; }

        public Checker(Color team, int row, int col)
        {
            if (this.team == Color.Black)
            {
                int openCircleId = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
                symbol = char.ConvertFromUtf32(openCircleId);
            }
            else
            {
                int closedCircleId = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
                symbol = char.ConvertFromUtf32(closedCircleId);

            }

            position = new Position(row, col);
        }
    }
}
