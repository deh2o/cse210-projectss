/*
EXCEEDING REQUIREMENTS

Added a Level System.

The player gains a new level every 1000 points earned.
This provides additional gamification beyond the core requirements.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
