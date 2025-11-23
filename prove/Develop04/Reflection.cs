using System.Runtime.InteropServices;

public class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflection(string activityName, string startMessage, string endMessage, int duration, List<string> prompts, List<string> questions) : base(activityName, startMessage, endMessage, duration)
    {
        this._prompts = prompts;
        this._questions = questions;
    }
    
    

    public void DisplayQuestions(int index)
    {
            Console.Write(_questions[index]);
            LoadingAnimation("dots");
        
    }

    public void DisplayPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count());
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {_prompts[index]} ---");
        Console.WriteLine();

    }
}