public class Listing : Activity
{
    private List<string> _prompts;
    private List<string> _itemList;

    public Listing(string startMessage, string endMessage, int duration, List<string> prompts, List<string> itemList) : base(startMessage, endMessage, duration)
    {

    }

    public string GetPrompt()
    {
        return "stupid";
    }
}