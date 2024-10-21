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
            Console.WriteLine("I thought of a number, try to guess it!");
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
            return rnd.Next(1, 11);
        }
    }
}
