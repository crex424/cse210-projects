using System.Runtime.CompilerServices;

public class Listing : Activity
{
    private List<string> _prompts;
    private List<string> _itemList = new List<string>();

    public Listing(string activityName, string startMessage, string endMessage, int duration, List<string> prompts) : base(activityName, startMessage, endMessage, duration)
    {
        this._prompts = prompts;
    }

    public void DisplayPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count());
        Console.WriteLine($" --- {_prompts[index]} ---");
    }

    public void AddItem()
    {
        string item = Console.ReadLine();
        _itemList.Add(item);
    }

    public int GetItemListSize()
    {
        return _itemList.Count();
    }
}