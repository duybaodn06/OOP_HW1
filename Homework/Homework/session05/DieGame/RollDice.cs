using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05.DieGame
{
    internal class Program
    {
        static void GameEngine()
        {
            int budget = 1000;
            Console.WriteLine("Welcome to the Double Dice Game!");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            bool playAgain = true;
            
            while (playAgain)
            {
                // Game logic goes here
                Console.WriteLine($"Your current budget: {budget}");
                Console.Write("Enter your bet amount: ");
                int betAmount = int.Parse(Console.ReadLine());

                Console.Write("Enter your bet choice (2-12): ");
                int betChoice;
                while (!int.TryParse(Console.ReadLine(), out betChoice) || betChoice < 2 || betChoice > 12)
                {
                    Console.WriteLine("Error! Enter your bet choice (2-12): ");
                }
                PairOfDice pod = new PairOfDice();
                Console.WriteLine($"You rolled: {pod.getDiceScore()}");
                if ((pod.getDiceScore() > 6 && betChoice > 6) || pod.getDiceScore() < 6 && betChoice < 6) budget += betAmount;
                else if (pod.getDiceScore() == 6 && betChoice == 6) budget += 3 * betAmount;
                else budget -= 2 * betAmount;

                Console.WriteLine($"Your new budget: {budget}");
                Console.Write("Do you want to play again? (y/n): ");
                string temp = Console.ReadLine();
                while (temp.ToLower() != "y" && temp.ToLower() != "n")
                {
                    Console.WriteLine("Error! Do you want to play again? (y/n): ");
                    temp = Console.ReadLine();
                }
                if (temp.ToLower() == "y" )
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
                Console.WriteLine("------------------------");
                if (budget <= 0 || !playAgain)
                {
                    playAgain = false;
                }
            }
        }
        static void Main06(string[] args)
        {
            GameEngine();


        }
    }
}
