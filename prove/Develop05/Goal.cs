

public class Goal
{
    private string _goalName;
    private int _totalPoints;
    private int _pointsOnCompletion;
    private bool _isCompleted;

    public Goal(string goalName, int totalPoints, int pointsOnCompletion, bool isCompleted)
    {
        this._goalName = goalName;
        this._totalPoints = totalPoints;
        this._pointsOnCompletion = pointsOnCompletion;
        this._isCompleted = isCompleted;
    }

    public void IsComplete()
    {

    }

    public virtual void RecordEvent()
    {
        
    }

    public virtual void AccumulatePoints()
    {

    }

    public void DisplayPoints()
    {
        
    }
}