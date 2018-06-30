using System;

namespace learntocode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            //string name = "DevChatter";
            //Console.WriteLine($"I really like the name {name}!");
            Console.WriteLine($"Hello {name}");

            Console.WriteLine($"So, {name}, what's your favorite number?");
            string rawText = Console.ReadLine();
            //int unsafeInt = int.Parse(rawText);
            int.TryParse(rawText, out int number);

            if (number < 5)
            {
                number = 5;
                Console.WriteLine($"The minimum number is five, so I updated your choice to {number}");
            }

            // number = number +2;
            // Console.WriteLine($"I like {number} better, so I changed to it for you.");

            // Console.WriteLine($"You chose {number}.");
            // int betterNumber = number + 1;
            // Console.WriteLine($"I like the number {betterNumber} better. It's larger.");

            // int i = 0;
            // while (i < number)
            // {
            //     Console.WriteLine($"You are awesome, {name}!");
            //     i++; // increments value of i
            // }

            
            //(initialize; compare; increment)
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"You are awesome! {name}");
            }

            // object s= "7";
            // object n = 7;
            // Console.WriteLine(s == n);

            

            // if (number == 7)
            // {
            //     Console.WriteLine("That's great! Seven is a common favorite number!");
            // }            

            // if (number == 13)
            // {
            //     Console.WriteLine("That's strange! Many people are afraid of 13!");
            // }
            
            
        }
    }
}
