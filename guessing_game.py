#I have included in my game an option that it gives the opponent an option to retry every time a guess is wrong

import random

def number_guessing_game():
    """
    A simple number guessing game where the user tries to guess a random number.
    """

    # Generate a random number between 1 and 100 (inclusive)
    secret_number = random.randint(1, 100)

    # Initialize the number of guesses
    guesses = 0

    print("Welcome to the Number Guessing Game!")
    print("I'm thinking of a number between 1 and 100.")

    while True:
        try:
            # Get the user's guess
            guess = int(input("Enter your guess: "))
            guesses += 1 #increment guess count

            # Check if the guess is correct
            if guess == secret_number:
                print(f"Congratulations! You guessed the number in {guesses} guesses.")
                break #exit loop if guess is correct
            # Provide hints if the guess is too high or too low
            elif guess < secret_number:
                print("Too low. Try again.")
            else:
                print("Too high. Try again.")

        except ValueError:
            # Handle invalid input (non-integer)
            print("Invalid input. Please enter a number.")

if __name__ == "__main__":
    number_guessing_game() #start the game