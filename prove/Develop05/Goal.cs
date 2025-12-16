
public class Goal
{
    private string _goalName;
    private string _description;
    private int _id;
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

    public void SetComplete(bool isCompleted)
    {
        _isCompleted = isCompleted;
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
        if (_isCompleted == false)
        {
            AccumulatePoints();
        }
        _isCompleted = true;
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

    public void SetID(int id)
    {
        _id = id;
    }

    public int GetID()
    {
        return _id;
    }
    public int GetPointOnCompletion()
    {
        return _pointsOnCompletion;
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
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