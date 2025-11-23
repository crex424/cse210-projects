public class Breathing : Activity
{
    public Breathing(string activityName, string startMessage, string endMessage, int duration) : base(activityName ,startMessage, endMessage, duration)
    {
        
    }

    public void DisplayMessage()
    {
        Console.Write("Breath In...");
        LoadingAnimation("countdown", 4);
        Console.Write("Breath Out...");
        LoadingAnimation("countdown", 6);
        Console.WriteLine();
    }
}