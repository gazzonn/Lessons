using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"Guess the Number\" by gazzonn");
        Start:
            Console.WriteLine("Choose the difficulty: Easy (1), Medium (2) or Hard (3).");
            int randomNumber = GenerateNumber();
            while (true)
            {
                try
                {
                    int guessedNumber = Convert.ToInt16(Console.ReadLine());
                    if (guessedNumber == randomNumber)
                    {
                        Console.WriteLine($"Yes! It's {randomNumber}. You won!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No. Try again!");
                    }
                }
                catch
                {
                    Console.WriteLine("The input must be integer.");
                }
            }
            Console.WriteLine("Would you like to play again? (Y or N)");
            while (true)
            {
                string answer = Convert.ToString(Console.ReadLine());
                if (answer == "Y" || answer == "y")
                {
                    goto Start;
                }
                else if (answer == "N" || answer == "n")
                {
                    Console.WriteLine("Thank you for playing! Bye <3");
                    break;
                }
                else
                {
                    Console.WriteLine("The input must be Y (y) or N (n).");
                }
            }
        }
        static int GenerateNumber()
        {
            Random rnd = new Random();
            while (true)
            {
                string difficulty = Convert.ToString(Console.ReadLine());
                if (difficulty == "1")
                {
                    Console.WriteLine("I have chosen the number from 1 to 10. Try to guess it!");
                    return rnd.Next(1, 11);
                    break;
                }
                else if (difficulty == "2")
                {
                    Console.WriteLine("I have chosen the number from 1 to 100. Try to guess it!");
                    return rnd.Next(1, 101);
                    break;
                }
                else if (difficulty == "3")
                {
                    Console.WriteLine("I have chosen the number from 1 to 1000. Try to guess it!");
                    return rnd.Next(1, 1001);
                    break;
                }
                else
                {
                    Console.WriteLine("The input must be 1, 2 or 3.");
                }
            }
        }
    }
}
