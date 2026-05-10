using System;

class Program
{
    static void Main(string[] args)
    {
        //Lets welcome Users to the program
        Console.WriteLine("Welcome to the program!");

        //for readability, lets leave a line before user input.
        Console.WriteLine("");

        //Lets get the user's first name.
        Console.WriteLine("Please tell us your first name?");
        string firstName = Console.ReadLine();

        //for readability, lets leave a line before user input.
        Console.WriteLine("");

        //Lets get the user's last name.
        Console.WriteLine("Please tell us your last name?");
        string lastName = Console.ReadLine();

        //for readability, lets leave a line before user input.
        Console.WriteLine("");

        //Print the user's full name.
        Console.Write($"Welcome! Your name is {lastName}, {firstName} {lastName}.");

    }
}
