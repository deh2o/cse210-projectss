using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        //Lets welcome Users to the program
        Console.WriteLine("Welcome to the program!");
        Console.WriteLine("Hint: Please enter a score between 0 and 100.");

        //for readability, lets leave a line before user input.
        Console.WriteLine("");

        //Initialize the needed variables for this project
        string firstName;
        string lastName;
        string letterGrade;
        string gradeMessage;
        int gradeScore;
        string gradeSign = "";

        //Lets get the user's first name.
        Console.WriteLine("Please tell us your first name?");
        firstName = Console.ReadLine();

        //for readability, lets leave a line before user input.
        Console.WriteLine("");

        //Lets get the user's last name.
        Console.WriteLine("Please tell us your last name?");
        lastName = Console.ReadLine();

        //for readability, lets leave a line before user input.
        Console.WriteLine("");

        //Lets get the user's score.
        Console.WriteLine("What was your % score in the class?");
        gradeScore = int.Parse(Console.ReadLine());

        //for readability, lets leave a line before user input.
        Console.WriteLine("");

        //Lest set the letter grade based on the Input.
        if (gradeScore >= 0 && gradeScore <= 100)
        {
            // Set up letter grade based on the score.
            if (gradeScore >= 90)
            {
                letterGrade = "A";
            }
            else if (gradeScore >= 80)
            {
                letterGrade = "B";
            }
            else if (gradeScore >= 70)
            {
                letterGrade = "C";
            }
            else if (gradeScore >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            //Set up grade sign based on the last digit of the score.

            //Set Grades sign for "A" and "F" and other letter grades.
            // for Grade F

            int lastDigit = gradeScore % 10;

            if (letterGrade != "F")
            {
                if (letterGrade == "A" && lastDigit <= 3)
                {
                    gradeSign = "-";
                }
                else if (letterGrade == "A" && lastDigit >= 7)
                {
                    gradeSign = "";
                }
                else
                {
                    if (lastDigit >= 7)
                    {
                        gradeSign = "+";
                    }

                    else if (lastDigit <= 3)
                    {
                        gradeSign = "-";
                    }

                    else
                    {
                        gradeSign = "";
                    }
                }
            }
        }
        else
        {
            letterGrade = "Invalid Score. You entered an invalid exams score.";
            gradeSign = "";
        }


        //Condition to check if user passed or failed the class.
        if (gradeScore >= 70 && gradeScore <= 100)
        {
            gradeMessage = "Congratulations! You passed the class!";
        }

        else if (gradeScore < 70 && gradeScore >= 0)
        {
            gradeMessage = "Sorry, you failed the class. Try better next time!";
        }

        else
        {
            gradeMessage = "Invalid Result";
        }

        //Print Result output
        Console.WriteLine($"Hello! {firstName} {lastName}.");
        Console.WriteLine($"Student Grade: {letterGrade}{gradeSign}");
        Console.WriteLine($"Remark: {gradeMessage}");

        //for readability, lets leave a line before user input.
        Console.WriteLine("");
    }
}
