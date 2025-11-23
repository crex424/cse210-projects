public class Activity
{
    private string _activityName;
    private string _startMessage;
    private string _endMessage;
    private int _duration;

    public Activity(string activityName, string startMessage, string endMessage, int duration)
    {
        this._activityName = activityName;
        this._startMessage = startMessage;
        this._endMessage = endMessage;
        this._duration = duration;

    }

    public void BeginActivity()
    {
        DisplayStartMessage();
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine();
        Console.WriteLine(_startMessage);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine(_endMessage);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
        LoadingAnimation("dots", 6);
    }

    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        _duration = seconds;
        return seconds;
    }

    public void LoadingAnimation(string loading, int index)
    {
        if (loading == "dots")
        {
            for (int i = 1; i <= index; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
                if (i % 3 == 0)
                {
                    Console.Write("\b\b\b   \b\b\b");
                }
            }
        }
        if (loading == "countdown")
        {
            for (int i = index; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        
        Console.WriteLine();
    }
}