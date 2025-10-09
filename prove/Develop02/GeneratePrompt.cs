
public class GeneratePrompt
{
    public List<string> _prompts = new List<string>();

    public string GetPrompt()
    {
        Random rand = new Random();
        int random_num = rand.Next(6);
        return _prompts[random_num];
    }

    public void Display()
    {
        for (int i = 0; i < _prompts.Count; i++)
        {
            Console.WriteLine($"{_prompts}");
        }

    }
}