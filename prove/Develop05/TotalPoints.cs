
public class TotalPoints
{
    private int _points;

    public TotalPoints(int points)
    {
        _points = points;
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_points} points.");
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points += points;
    }
}