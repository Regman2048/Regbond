using System;

public class ProgramFunctions
{
    // Function to display the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt the user for their favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number;
        while (!int.TryParse(input, out number))
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
            Console.Write("Please enter your favorite number: ");
            input = Console.ReadLine();
        }
        return number;
    }

    // Function to square a given integer and return the result
    static int SquareNumber(int num)
    {
        return num * num;
    }

    // Function to display the user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"\nHello, {name}! Your favorite number squared is: {squaredNumber}");
    }

    static void Main(string[] args)
    {
        // Call the DisplayWelcome function
        DisplayWelcome();

        // Call the PromptUserName function to get the user's name
        string userName = PromptUserName();

        // Call the PromptUserNumber function to get the user's favorite number
        int favoriteNumber = PromptUserNumber();

        // Call the SquareNumber function to square the favorite number
        int squaredFavoriteNumber = SquareNumber(favoriteNumber);

        // Call the DisplayResult function to show the results
        DisplayResult(userName, squaredFavoriteNumber);
    }
}