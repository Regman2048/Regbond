using System;

public class GuessingGame
{
    public static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Step 3: Generate a random magic number
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("Welcome to the Guessing Game!");

            // Step 2: Loop until the guess is correct
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    guessCount++;

                    // Step 1: Determine if the guess is higher or lower
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            // Step 4: Inform the user of the number of guesses
            Console.WriteLine($"You guessed it in {guessCount} tries.");

            // Step 5: Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}