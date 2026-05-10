using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum;
        int userNum;
        int tries = 0;

        //Lets welcome users to the program
        Console.WriteLine("Welcome to the Program!");

        //for readability, lets leave a line before user input.
        Console.WriteLine("");

        // ****************Part 1************************
        // // set random number from user input
        // Console.WriteLine("Enter a number between 1 and 100:");
        // magicNum = int.Parse(Console.ReadLine());

        // // get user guess
        // Console.WriteLine("What is your guess?");
        // userNum = int.Parse(Console.ReadLine());

        // // Set a condition to compare the magic number and user input
        //         if (userNum == magicNum)
        //         {
        //             Console.WriteLine("Congratulations! You guessed right.");
        //             Console.WriteLine($"You got it in {tries} tries.");

        //             //for readability, lets leave a line.
        //             Console.WriteLine("");
        //         }

        //         else if (userNum != magicNum && userNum < magicNum)
        //         {
        //             Console.WriteLine("Sorry! Guess higher next time.");
        //             //for readability, lets leave a line.
        //             Console.WriteLine("");
        //         }

        //         else if (userNum != magicNum && userNum > magicNum)
        //         {
        //             Console.WriteLine("Sorry! Guess lower next time.");
        //             //for readability, lets leave a line.
        //             Console.WriteLine("");
        //         }

        //         else
        //         {
        //             Console.WriteLine("Invalid input");
        //             //for readability, lets leave a line.
        //             Console.WriteLine("");
        //         }

        // ****************Part 1 END************************

        // Set the Magic number using Random generator
        magicNum = randomGenerator.Next(1, 100);

        // Lest set a loop to repeat the process till the right number is guess.
        do
        {
            // get user guess
            Console.WriteLine("What is your guess?");
            userNum = int.Parse(Console.ReadLine());

            // increment tries by 1
            tries += 1;

            // Set a condition to compare the magic number and user input
            if (userNum == magicNum)
            {
                Console.WriteLine("Congratulations! You guessed right.");
                Console.WriteLine($"You got it in {tries} tries.");

                //for readability, lets leave a line.
                Console.WriteLine("");
            }

            else if (userNum != magicNum && userNum < magicNum)
            {
                Console.WriteLine("Sorry! Guess higher next time.");
                //for readability, lets leave a line.
                Console.WriteLine("");
            }

            else if (userNum != magicNum && userNum > magicNum)
            {
                Console.WriteLine("Sorry! Guess lower next time.");
                //for readability, lets leave a line.
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("Invalid input");
                //for readability, lets leave a line.
                Console.WriteLine("");
            }
        } while (userNum != magicNum);

    }
}
