public class EternalGoal : Goals
{
    private int _timesCompleted;

    public EternalGoal()
    {
        _goalType = "EternalGoal";
        _timesCompleted = 0;
    }

    public EternalGoal(string name, string description, int points, int timesCompleted)
    {
        _goalType = "EternalGoal";
        _name = name;
        _description = description;
        _points = points;
        _timesCompleted = timesCompleted;
    }

    public override void CreateGoal()
    {
        base.CreateGoal();
    }

    public override int SetPoints()
    {
        _timesCompleted++;
        return _points;
    }

    public override bool IsDone()
    {
        return false;
    }

    public override string GetSaveString()
    {
        return $"{_goalType}|{_name}|{_description}|{_points}|{_timesCompleted}";
    }
}
