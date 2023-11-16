using System;

class Entry// this is the class entry so we can use it to receive the entries user.
{
    public string _date { get; }
    public string _promptText { get; }
    public string _entryText { get; }

    public Entry(string dateToday, string promptText, string entryText)
    {
        _date = dateToday;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry:{_entryText}\n");
    }
}