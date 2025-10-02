using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guesses;
        do
        {
            Console.Write("What is your guess? ");
            guesses = int.Parse(Console.ReadLine());

            if (number > guesses)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guesses)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (number != guesses);
    }
}
