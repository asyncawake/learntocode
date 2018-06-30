using System;

namespace learntocode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // This is the "secret" number
            int number = 4;

            Console.WriteLine("I've chosen a secret number! can you gues it?!?!?");

            int guess;
            do
            {
                Console.WriteLine("What's your guess?");
                string guessString = Console.ReadLine();
                int.TryParse(guessString, out guess);

                if (guess < number)
                {
                    Console.WriteLine("You are too low. Guess higher next time");
                }

                if (guess > number)
                {
                    Console.WriteLine("You are too high. Guess lower next time");
                }

            } while (guess != number);
            Console.WriteLine("You got it!");

        }
    }
}
