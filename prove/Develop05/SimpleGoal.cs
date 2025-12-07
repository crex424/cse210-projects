public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, int totalPoints, int pointsOnCompletion, bool isCompleted) : base(goalName, totalPoints, pointsOnCompletion, isCompleted)
    {

    }

    public override void RecordEvent()
    {
        
    }
}