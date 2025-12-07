public class CheckListGoal : Goal
{
    private int _requiredCompletions;
    private int _completions;


    public CheckListGoal(string goalName, int totalPoints, int pointsOnCompletion, bool isCompleted, int requiredCompletions, int completions) : base(goalName, totalPoints, pointsOnCompletion, isCompleted)
    {
        this._requiredCompletions = requiredCompletions;
        this._completions = completions;
    }

    public override void AccumulatePoints()
    {
        
    }
}