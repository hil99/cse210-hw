using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_promptText}\n{_entryText}\n");
    }
}