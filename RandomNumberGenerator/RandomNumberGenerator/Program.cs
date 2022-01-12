using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int min, max, randNum;
            string minAnswer, maxAnswer, answer = string.Empty;

            Console.WriteLine("Welcome to the random number generator!");

            do
            {
                Console.WriteLine("Please enter in a minimum number:");
                minAnswer = Console.ReadLine();
                while (int.TryParse(minAnswer, out min) == false)
                {
                    Console.WriteLine("You did not enter in an integer. Please try agian!");
                    minAnswer = Console.ReadLine();
                }

                Console.WriteLine("Please enter in a maximum number:");
                maxAnswer = Console.ReadLine();
                while (int.TryParse(maxAnswer, out max) == false)
                {
                    Console.WriteLine("You did not enter in an integer. Please try agian!");
                    maxAnswer = Console.ReadLine();
                }

                randNum = rand.Next(min, max + 1);

                Console.WriteLine($"The random number was: {randNum}");

                Console.WriteLine("Would you like to do it again? Type 'yes' or 'no'");
                answer = Console.ReadLine().ToLower();
            } while (answer[0] != 'n');
        }
    }
}
