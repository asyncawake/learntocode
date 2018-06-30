using System;

namespace learntocode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 2; i < 10; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("This one is four!");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Random rand = new Random();
            // int number = rand.Next(1,1_000); // chose a random number between 1 and a million. The underscores make large number more readable.

            // Console.WriteLine("I've chosen a secret number between 1 and 1,000,000! Can you gues it?!?!?");

            // int guess;
            // do
            // {
            //     Console.WriteLine("What's your guess?");
            //     string guessString = Console.ReadLine();
            //     int.TryParse(guessString, out guess);

            //     if (guess < number)
            //     {
            //         Console.WriteLine("You are too low. Guess higher next time");
            //     }

            //     if (guess > number)
            //     {
            //         Console.WriteLine("You are too high. Guess lower next time");
            //     }

            // } while (guess != number);
            // Console.WriteLine("You got it!");

        }
    }
}
