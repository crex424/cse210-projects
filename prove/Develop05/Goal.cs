

public class Goal
{
    private string _goalName;
    private string _description;
    private int _totalPoints;
    private int _pointsOnCompletion;
    private bool _isCompleted;

    public Goal(string goalName, string description, int pointsOnCompletion, bool isCompleted)
    {
        this._goalName = goalName;
        this._description = description;
        this._pointsOnCompletion = pointsOnCompletion;
        this._isCompleted = isCompleted;
    }

    public bool IsComplete()
    {
        return _isCompleted;
    }

    public void SetTotalPoint(int total_points)
    {
        _totalPoints = total_points;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual void RecordEvent()
    {
        _isCompleted = true;
        AccumulatePoints();
    }

    public void AccumulatePoints(bool bonus = false, int bonus_points = 0)
    {
        if (bonus == false)
        {
            _totalPoints += _pointsOnCompletion;
        }
        else
        {
            _totalPoints += _pointsOnCompletion + bonus_points;
        }

    }
    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
    }

    public virtual void DisplayGoalInfo()
    {
        string check_box = "[]";
        if (IsComplete())
        {
            check_box = "[X]";
        }
        Console.WriteLine($"{check_box} {_goalName} ({_description})");
    }
}