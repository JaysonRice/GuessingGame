using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            int secretNumber = rand.Next(1, 101);

            int guessesGiven = 0;

            Console.WriteLine($"Choose difficulty: Easy, Medium, Hard, or Cheater");
            string userDifficulty = Console.ReadLine();

            int numberOfGuesses = new int();

            if (userDifficulty == "Easy")
            {
                Console.WriteLine("You get 8 guesses.");
                numberOfGuesses = 8;
            }
            else if (userDifficulty == "Medium")
            {
                Console.WriteLine("You get 6 guesses.");
                numberOfGuesses = 6;
            }
            else if (userDifficulty == "Hard")
            {
                Console.WriteLine("You get 4 guesses.");
                numberOfGuesses = 4;
            }
            else if (userDifficulty == "Cheater")
            {
                Console.WriteLine("You get infinite guesses.");
                numberOfGuesses = 999999999;
            }
            else
            {
                Console.WriteLine("You failed to enter difficulty properly. Defaulted to 8 guesses.");
                numberOfGuesses = 8;
            }

            while (guessesGiven < numberOfGuesses)
            {
                Console.WriteLine($"Guess the secret number! Your guess ({guessesGiven + 1})");
                string userGuess = Console.ReadLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine("Yup! You guessed it.");
                    break;
                }
                else if (userGuessInt > secretNumber)
                {
                    Console.WriteLine("Nope, too high.");
                }
                else
                {
                    Console.WriteLine("Nope, too low.");
                }
                guessesGiven++;
                if (guessesGiven == numberOfGuesses)
                {
                    Console.WriteLine($"You lose! The number was {secretNumber}.");
                }
            }


        }
    }
}
