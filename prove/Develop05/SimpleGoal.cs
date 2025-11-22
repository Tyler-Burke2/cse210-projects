public class SimpleGoal : Goals
{
    private bool _isComplete;

    public SimpleGoal()
    {
        _goalType = "SimpleGoal";
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete)
    {
        _goalType = "SimpleGoal";
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override void CreateGoal()
    {
        base.CreateGoal();
    }

    public override int SetPoints()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsDone()
    {
        return _isComplete;
    }

    public override string GetSaveString()
    {
        return $"{_goalType}|{_name}|{_description}|{_points}|{_isComplete}";
    }
}