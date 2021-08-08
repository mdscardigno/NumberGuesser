using System;

namespace NumberGuesser
{
    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Hello there!.\n" +
            "Think of a number between 1 and 1024. \n" +
            "I bet I can guess it.");
            Console.WriteLine("----------------------------------------------");
        }
        static void Main(string[] args)
        {
            {
                DisplayGreeting();
                int lowest = 1;
                int highest = 1024;
                int differenceOfRange = highest - lowest;
                int midpoint = differenceOfRange / 2;
                int midValue = lowest + midpoint;
                bool secretNumber = true;

                Console.WriteLine("Pick a secret number between 1 to 100. Press enter to continue");
                Console.ReadKey();
                while (lowest <= highest && secretNumber)
                {
                    differenceOfRange = highest - lowest;
                    midpoint = differenceOfRange / 2;
                    midValue = lowest + midpoint;

                    Console.WriteLine("Is your secret number: {0}", midValue);
                    Console.WriteLine(" 1: No my secret number is lower \n 2: No my secret number is greater \n 3: That is my secret number! ");
                    int userChoiceToInt = int.Parse(Console.ReadLine());
                    int userChoice = userChoiceToInt;
                    if (userChoice == 3)
                    {
                        Console.WriteLine("Computer Wins!");
                        secretNumber = false;
                    }

                    if (lowest < highest && userChoice == 2)
                    {
                        lowest = midValue + 1;
                        Console.WriteLine("Your number is {0}", midValue);
                    }
                    else if (lowest < highest && userChoice == 1)
                    {
                        highest = midValue - 1;
                        Console.WriteLine("Your number is {0}", midValue);
                    }
                }

            }

        }
    }
}
