// EXCEEDING REQUIREMENTS:
//
// 1. Reflection questions do not repeat until all available
//    questions have been used.
//
// 2. Added activity statistics tracking that records how many
//    Breathing, Reflection, and Listing activities have been
//    completed during the session and displays totals.


using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "5")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. View Statistics");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;

                case "2":
                    new ReflectionActivity().Run();
                    break;

                case "3":
                    new ListingActivity().Run();
                    break;

                case "4":
                    ActivityTracker.DisplayStats();
                    Console.Write("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    Thread.Sleep(1000);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}
