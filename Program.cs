
using System;

namespace AH_Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] Dice = new int[7];


            // used variables
            string response;
            string sides;

            do
            {
                Console.WriteLine("Welcome to GrandCircus Casino. Roll the dice (y/n?)");
                _ = Console.ReadLine().ToLower();

                // User will enter a number of sides
                Console.WriteLine("How many sides does each dice have?");
                sides = Console.ReadLine();
                _ = int.TryParse(sides, out _);

                // Dice roll, used for 6 sides

                Console.WriteLine("Your Dice Roll:");
                int diceRoll = rnd.Next(6);
                Dice[diceRoll]++;
                Console.WriteLine("Dice 1: {0}", diceRoll + 1);
                diceRoll = rnd.Next(6);
                Dice[diceRoll]++;
                Console.WriteLine("Dice 2: {0}", diceRoll + 1);
                Console.WriteLine("Would you like to Roll again? (y/n?)");
                response = Console.ReadLine();

                //To prompt user to go again w/while loop
            } while (response == "y");

            {
                Console.WriteLine("GoodBye!");
                Console.ReadLine();
            }
        }
    }
}





