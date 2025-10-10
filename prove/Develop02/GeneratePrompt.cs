
public class GeneratePrompt
{
    public List<string> _prompts = new List<string>();

    public string GetPrompt()
    {
        Random rand = new Random();
        int random_num = rand.Next(_prompts.Count());
        return _prompts[random_num];
    }
}