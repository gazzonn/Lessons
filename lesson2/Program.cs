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
            Console.WriteLine("\"Guess the Number\" by gazzonn\nI thought of a number, try to guess it!");
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
            
        }
        static int GenerateNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 11);
        }
    }
}
