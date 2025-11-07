public class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _question;

    public Reflection(string startMessage, string endMessage, int duration, List<string> _prompts, List<string> _question) : base(startMessage, endMessage, duration)
    {

    }

    public string GetQuestion()
    {
        return "hello";
    }

    public string GetPrompt()
    {
        return "Kinda";
    }

    public void DisplayPrompt()
    {
        
    }
}