using System;
using System.Collections.Generic; //importing the Collections.Generic namespace to use List<T>

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); // Creating a new list to store numbers

        //Lets welcome users to the program
        Console.WriteLine("Welcome to the Program!");

        //for readability, lets leave a line.
        Console.WriteLine("");

        // Get user inputs to append to the list
        Console.WriteLine("Enter a number to add to the list (or type '0' to finish):");
        int userInput = int.Parse(Console.ReadLine());

        // set a loop to continue accepting user input until they type '0'
        while (userInput != 0)
        {
            numbers.Add(userInput);
        }

        // Set an end to user input and print the list of numbers
        Console.WriteLine(" Input Complete! Below is your input Result");

        //for readability, lets leave a line.
        Console.WriteLine("");

        // Print the list of numbers entered by the user
        Console.WriteLine($"Your List of Numbers:" + "" + numbers + "," + "");

    }
}
