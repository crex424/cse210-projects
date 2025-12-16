public class CheckListGoal : Goal
{
    private int _requiredCompletions;
    private int _completions;
    private int _bonusPoints;


    public CheckListGoal(string goalName, string description, int pointsOnCompletion, bool isCompleted, int requiredCompletions, int completions, int bonusPoints) : base(goalName, description, pointsOnCompletion, isCompleted)
    {
        this._requiredCompletions = requiredCompletions;
        this._completions = completions;
        this._bonusPoints = bonusPoints;
    }
    public override void RecordEvent()
    {
        _completions += 1;
        AccumulatePoints();
        if (_completions == _requiredCompletions)
        {
            AccumulatePoints(true, _bonusPoints);
        }
    }

    public override void DisplayGoalInfo()
    {
        string check_box = "[]";
        if (_completions == _requiredCompletions)
        {
            check_box = "[X]";
        }
        Console.WriteLine($"{check_box} {GetGoalName()} ({GetDescription()}) -- Currently completed: {_completions}/{_requiredCompletions}");
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public int GetCompletions()
    {
        return _completions;
    }

    public int GetRequiredCompletions()
    {
        return _requiredCompletions;
    }
}