using System;

namespace RockPaperScissors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int playerWins = 0;

            int cpuWins = 0;

            Console.WriteLine("Let's Play a Game.");

            for (int i = 0; i < 10; i++)
            {


                Console.WriteLine("Choose rock, paper, or scissors");

                string hand = Console.ReadLine();

                string[] choices = { "rock", "paper", "scissors" };

                Random r = new Random();

                string cpuHand = choices[r.Next(0, 3)];

                string winner = CompareHands(hand, cpuHand);

                Console.WriteLine("CPU chooses " + cpuHand);

                Console.WriteLine(winner);

                if (winner == "You Win!")
                {
                    playerWins++;
                }

                else if (winner == "You Lose!")
                {
                    cpuWins++;
                }

                Console.WriteLine("You: " + playerWins);

                Console.WriteLine("CPU: " + cpuWins);



            }

            if (playerWins > cpuWins)
            {
                Console.WriteLine("You've won the match");
            }

            else if (cpuWins > playerWins)
            {
                Console.WriteLine("You've lost the match, good job.");
            }

            else
            {
                Console.WriteLine("The match ends in a tie.");
            }
        }

        public static string CompareHands(string player, string cpu)
        {
            if (player == "rock")
            {
                if (cpu == "paper")
                {
                    return "You Lose!";
                }
                if (cpu == "rock")
                {
                    return "Tie";
                }
                if (cpu == "scissors")
                {
                    return "You Win!";
                }

                
            }
            if (player == "paper")
            {
                if (cpu == "rock")
                {
                    return "You Win!";
                }
                if (cpu == "paper")
                {
                    return "Tie";
                }
                if (cpu == "scissors")
                {
                    return "You Lose!";
                }
            }
            if (player == "scissors")
            {
                if (cpu == "rock")
                {
                    return "You Lose!";
                }
                if (cpu == "paper")
                {
                    return "You Win!";
                }
                if (cpu == "scissors")
                {
                    return "Tie";
                }
            }

            return "ERROR!";
        }


    }
}
