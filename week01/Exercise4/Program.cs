using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Welcome to the Program!\n"); 

        // The loop needs to ask for a NEW input every time it runs
         int inputNumber = -1;
        while ( inputNumber != 0)
        {
            Console.WriteLine("Enter a number (or enter 0 to quit");
            string userInput = Console.ReadLine();
            
            //parse the input into a digit
            inputNumber = int.Parse(userInput);
            
            //lets add numbers when its not 0
            if ( inputNumber != 0)
            {
            	numbers.Add(inputNumber);
            }
        } 
        
        // Set an end to user input and print the list of numbers
        Console.WriteLine(" Input Complete! Below is your input Result");

        //for readability, lets leave a line.
        Console.WriteLine("");

        // Print the list of numbers entered by the user
        Console.WriteLine($"Your List of Numbers: {string.Join(", ", numbers)}");
        
        //Calculator the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"the sum of the numbers is: {sum}");
        
        //calculate the average 
        float average = sum / numbers.Count;
        Console.WriteLine($"the average is: {average}");
        
        //lets try and check max number
        int max = numbers[0];
        
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"the maximum number is: {max}");
    }
}
