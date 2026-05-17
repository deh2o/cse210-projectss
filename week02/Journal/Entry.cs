using System;

public class Entry
{
    // Member variables to store the date, prompt, and journal entry text
    public string _date;
    public string _promptText;
    public string _entryText;

    // Constructor to initialize the member variables
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Method to display the entry details
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}\n");
    }
}
