using System;

namespace NumberGuesser
{
    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Hello and Welcome to our Game!");
            Console.WriteLine("----------------------------------------------");
        }
        static string PromptForAString(string prompt)
        {
            Console.Write(prompt);
            //get user input
            var userInput = Console.ReadLine();
            return userInput;
        }
        static string IsUserInputCorrectGuess(string prompt)
        {
            Console.Write(prompt);
            var IsUserInputCorrectGuess = Console.ReadLine();
            return IsUserInputCorrectGuess;
        }
        static int PromptForAnInterger(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            var userInputAsInteger = int.Parse(userInput);
            //we are returning the user input as an integer
            return userInputAsInteger;
        }

        static void Main(string[] args)
        {
            DisplayGreeting();
            Random random = new Random();
            int numberToGuess = random.Next(1, 1024);
            string userName = PromptForAString("What is your name?: ");//method being used
            int userGuess = PromptForAnInterger($"{userName}, I am thinking of a number betwee 1 - 1024. Can you guess the number?: ");
            if (userGuess != numberToGuess)
            {
                if (userGuess < numberToGuess)
                {
                    //how can I not repeat myself?
                    Console.WriteLine($"No. The number I am thinking about is higher than {userGuess}. Can you guess what it is?");
                }
                if (userGuess > numberToGuess)
                {
                    Console.WriteLine($"No. The number I am thinking about is lower than {userGuess}. Can you guess what it is?");
                    Console.Write($"The mystery number was: {numberToGuess}. ");
                }
                else if (userGuess == numberToGuess)
                {
                    Console.WriteLine($"Congrats! You guessed it! The number was: {numberToGuess}");
                    Console.Write($"The mystery number was: {numberToGuess}. ");

                }

            };
        }
    }
}
