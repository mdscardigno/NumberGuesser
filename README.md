# NumberGuesser

<!-- Your program should be able to handle a person thinking of a number between 1 and 1024.
Your program should assume the human player would answer any guess truthfully.

Problem

Once the program starts, display a Welcome greeting to the user describing the challenge.

Prompt the user with your guess and allow them to tell you if their number is higher, lower, or correct.
Keep refining your guess until you have the correct answer.

Use methods to organize your code. Here are some suggestions for methods you might use:

ShowGreeting
ComputeNewLowIfTooLow
ComputeNewHighIfTooHigh
BragWhenCorrect
Use at least one or two methods

Possible solution approach besides:
What happens if the number is 0? specify range at random 1-1024?
How to know which number the computer picks?
Once I figure out what number it is save it to the correctNumber variable?

Example
Greeting to user or player and description of the game.
-Console.WriteLine("I am thinking of a number between 1-1024. Enter your best guess for a number: .")
-The guess will be a number therefore it will be an int. Grab the string and convert it to int and save it to a variable named playerNumber.

Data
-random
-lists
loops
-control flow if else or maybe switch or
-Input will be a number gotten as a string from the player.
-Convert that string from the user to an integer
Int.Parse.(playerNumber);
Console.WriteLine();
-Then check if the integer is equal to the random number pick by the computer.


Lists?
User Console.WriteLine() for message to user
If number is equal to the correctNumber then, you are right! Winner!!!
If number is greater than correctNumber then, too high!.
If number is less than correctNumber then, too low!.


loops

Algorithm

1- When game starts, Console.WriteLine() a greeting to the player, describing the challenge:

  Console.WriteLine("Greetings!. In this game, you, the player will try to guess a number from 1-1024. If number is correct, you win. If number is not correct, you loose.")
Define a variables
number

2- Game asks the player to guess the number.
  Console.WriteLine("I am thinking of a number between 1-1024. Enter your best guess for a number: .");

  If number is less than correctNumber then, print too low.
    Console.WriteLine("Nice try but your number is too low."); Ask the question again or step 2.

  If number is greater than correctNumber then, print too high.
    Console.WriteLine("Nice try but your number is too high."); Ask the question again or step 2.

  If number is equal to the correctNumber then, print you win!
  Console.WriteLine("That's the number. Congratulations. You win!.");

End the game.

Code
-->
