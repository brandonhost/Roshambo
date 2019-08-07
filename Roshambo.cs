using System;

namespace ro_sham_bo
{
    class Program
    {
        private static readonly string[] choices = { "rock", "paper", "scissors" };
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string playerName = Console.ReadLine();
        
            while (true) { 
                Console.WriteLine(playerName + ", choose a Rock, Paper or Scissors?");
                string pc = Console.ReadLine().ToLower();
                string cc = choices[rnd.Next(choices.Length)];

                if (pc.Equals("rock") && cc.Equals("rock"))
                {
                    Console.WriteLine("It's a draw!");
                }
                else if (pc.Equals("paper") && cc.Equals("rock"))
                {
                    Console.WriteLine("Paper beats Rock! Winner: " + playerName);
                }
                else if (pc.Equals("scissors") && cc.Equals("rock"))
                {
                    Console.WriteLine("Rock beats Scissors! Winner: Opponent");
                }

                else if (pc.Equals("rock") && cc.Equals("paper"))
                {
                    Console.WriteLine("Paper beats Rock! Winner: Opponent");
                }
                else if (pc.Equals("paper") && cc.Equals("paper"))
                {
                    Console.WriteLine("It's a draw!");
                }
                else if (pc.Equals("scissors") && cc.Equals("paper"))
                {
                    Console.WriteLine("Scissors beats Paper! Winner :" + playerName);
                }

                else if (pc.Equals("rock") && cc.Equals("scissors"))
                {
                    Console.WriteLine("Rock beats Scissors! Winner :" + playerName);
                }
                else if (pc.Equals("paper") && cc.Equals("scissors"))
                {
                    Console.WriteLine("Scissors beat paper! Winner : Opponent");
                }
                else if (pc.Equals("scissors") && cc.Equals("scissors"))
                {
                    Console.WriteLine("It's a draw!");
                }

                else
                {
                    Console.WriteLine("Not a valid choice.");
                }
            }
        }
    }
}