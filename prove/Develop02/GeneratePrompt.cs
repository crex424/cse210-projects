
public class GeneratePrompt
{
    public List<string> _prompts = new List<string>();

    public string GetPrompt()
    {
        Random rand = new Random();
        int random_num = rand.Next(_prompts.Count());
        return _prompts[random_num];
    }
    /*
    Displays all the prompts from a the prompt list.
    */
    public void Display()
    {
        for (int i = 0; i < _prompts.Count; i++)
        {
            Console.WriteLine($"{_prompts}");
        }

    }
}