public static class ActivityTracker
{
    private static int _breathingCount = 0;
    private static int _reflectionCount = 0;
    private static int _listingCount = 0;

    public static void RecordBreathing()
    {
        _breathingCount++;
    }

    public static void RecordReflection()
    {
        _reflectionCount++;
    }

    public static void RecordListing()
    {
        _listingCount++;
    }

    public static void DisplayStats()
    {
        Console.WriteLine("\nActivity Statistics");
        Console.WriteLine("-------------------");
        Console.WriteLine($"Breathing Activities: {_breathingCount}");
        Console.WriteLine($"Reflection Activities: {_reflectionCount}");
        Console.WriteLine($"Listing Activities: {_listingCount}");
        Console.WriteLine($"Total Activities: {_breathingCount + _reflectionCount + _listingCount}");
    }
}
