public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string description, int pointsOnCompletion, bool isCompleted) : base(goalName, description, pointsOnCompletion, isCompleted)
    {
        
    }

    public override void RecordEvent()
    {
        AccumulatePoints();
    }
}