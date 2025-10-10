using System.Runtime.CompilerServices;

public class Entry
{
    public string _entry;
    public string _date;
    public string _prompt;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_entry}");
        Console.WriteLine("");
    }

    public string GetDate()
    {
        DateTime current_date = DateTime.Now;
        string formatted_date = current_date.ToString("MM/dd/yyyy");
        return formatted_date;
    }
}