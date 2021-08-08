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

                Console.WriteLine("Think of a number between 1 to 1024. Press enter to continue");
                Console.ReadKey();
                //while lowest number is less or equal to the highest number and the secretNumber is true
                while (lowest <= highest && secretNumber)
                {
                    differenceOfRange = highest - lowest;
                    Console.Write($"the differeneOfRange is: {differenceOfRange} ");
                    midpoint = differenceOfRange / 2;
                    midValue = lowest + midpoint;
                    //starting at the middle 512
                    Console.WriteLine("Is your number: {0}", midValue);
                    //options to tell the computer if the number is too low, too high or correct
                    Console.WriteLine(" 1: No my  number is lower \n 2: No my number is greater \n 3: That is my number! ");
                    //prompt returns a string so we have to use int.Parse to convert the string to an integer
                    int userChoiceToInt = int.Parse(Console.ReadLine());
                    //we create a variable userChoice to store the integer
                    int userChoice = userChoiceToInt;
                    //we check what option the user selected
                    if (userChoice == 3)
                    {
                        Console.WriteLine("You guessed it!");
                        secretNumber = false;//the number is not longer secret therefore is false
                    }

                    if (lowest < highest && userChoice == 2)
                    {
                        //secret number is higher
                        lowest = midValue + 1;
                        Console.WriteLine("Your number was {0}", midValue);
                    }
                    //secret number is lower
                    else if (lowest < highest && userChoice == 1)
                    {
                        highest = midValue - 1;
                        Console.WriteLine("Your number was {0}", midValue);
                    }
                }

            }

        }
    }
}
