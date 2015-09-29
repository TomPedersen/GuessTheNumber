using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Summary
            //Choose an upper limit to determine a range of numbers starting with 1 from which a number will be picked that you'll need
            //to guess, and then choose an amount of attempts you'll get to find that number.
            //Summary

            GuessTheNumber(100, 10);
        }

        private static void GuessTheNumber(int limit, int attempts)
        {
            Console.WriteLine(
                "I'm thinking of a number between 1 and {0}. \nLet's see if you can guess what it is! You'll only get {1} tries!",
                limit, attempts);

            Random random = new Random();
            var guess = Console.ReadLine();
            int number = random.Next(1, limit);
            int tries = 0;
            bool guessed = false;

            while (tries < (attempts - 1))
            {
                if (int.Parse(guess) != number)
                {
                    if (int.Parse(guess) > number)
                    {
                        Console.WriteLine("The number I'm thinking of is less than that!");
                        guess = Console.ReadLine();
                        tries += 1;
                    }
                    if (int.Parse(guess) < number)
                    {
                        Console.WriteLine("The number I'm thinking of is greater than that!");
                        guess = Console.ReadLine();
                        tries += 1;
                    }
                }
                if (int.Parse(guess) == number)
                {
                    guessed = true;
                    break;
                }
            }

            if (guessed)
            {
                Console.WriteLine("You guessed the number! Hooray!");
            }
            else
            {
                Console.WriteLine("Sorry you couldn't guess the number :( it was {0}", number);
            }
            Console.ReadLine();
        }
    }
}