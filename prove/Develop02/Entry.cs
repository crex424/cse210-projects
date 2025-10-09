using System.Runtime.CompilerServices;

public class Entry
{
    public string _entry;
    public string _date;
    public string _prompt;

    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_entry}");
    }

    public string GetDate()
    {
        DateTime current_date = DateTime.Now;
        string formatted_date = current_date.ToString("MM/dd/yyyy");
        return formatted_date;
    }
    public Entry CreateEntry(string text, string prompt)
    {
        Entry entry = new Entry();
        entry._date = GetDate();
        entry._entry = text;
        entry._prompt = prompt;
        return entry;
    }
}