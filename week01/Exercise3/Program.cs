using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        string playAgain;

        do
            {
            Console.WriteLine("");
            Console.WriteLine("=======================");
            Console.WriteLine("GUESS THE MAGIC NUMBER!");
            Console.WriteLine("=======================");
            Console.WriteLine("");


            // Part 1 and 2
            // Console.WriteLine("What is the magic number?");
            // string magicNum = Console.ReadLine();
            // int magicNumber = int.Parse(magicNum);

            // Part 3 - Generate a random number and reset the game
            int magicNumber = randomGenerator.Next(1,100);
            int userGuess;
            int guessCount = 0;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("What's your guess for the magic number?");
                string guess = Console.ReadLine();
                userGuess = int.Parse(guess);

                guessCount++;

                Console.WriteLine("");

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            } while (userGuess != magicNumber);

            Console.WriteLine("Congratulations! You guessed it right!");
            Console.WriteLine($"You guessed in {guessCount} tries.");

            Console.WriteLine("");
            Console.WriteLine("Do you wnat to play again?");
            playAgain = Console.ReadLine().Trim().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}