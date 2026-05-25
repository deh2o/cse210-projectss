// EXCEEDING REQUIREMENTS:
// This program stores multiple scriptures and randomly selects one
// each time the program runs.

using System;

class Program
{
    static void Main(string[] args)
    {

        // Create a list of scriptures
        List<Scripture> scriptures = new List<Scripture>();

        // Add some scriptures to the list
        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life."
        ));

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight."
        ));

        scriptures.Add(new Scripture(
            new Reference("Psalm", 23, 1),
            "The Lord is my shepherd I shall not want."
        ));

        // Randomly select a scripture from the list
        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        // Loop to hide words until the scripture is completely hidden
        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(selectedScripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue or type 'quit' to finish:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            selectedScripture.HideRandomWords(3);
        }


        // Final display of the scripture after the loop ends
        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Program ended.");
    }
}
