public class ChecklistGoal : Goals
{
    private int _completedNumber;
    private int _goalNumber;
    private int _bonusPoints;

    public ChecklistGoal()
    {
        _goalType = "ChecklistGoal";
        _completedNumber = 0;
        _goalNumber = 0;
        _bonusPoints = 0;
    }

    public ChecklistGoal(string name, string description, int points, int goalNumber, int bonusPoints, int completedNumber)
    {
        _goalType = "ChecklistGoal";
        _name = name;
        _description = description;
        _points = points;
        _goalNumber = goalNumber;
        _bonusPoints = bonusPoints;
        _completedNumber = completedNumber;
    }

    public override void CreateGoal()
    {
        base.CreateGoal();

        Console.Write("How many times does this goal need to be accomplished? ");
        _goalNumber = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public string IsDoneTimes()
    {
        return $"{_completedNumber}/{_goalNumber}";
    }

    public override int SetPoints()
    {
        if (_completedNumber < _goalNumber)
        {
            _completedNumber++;
            if (_completedNumber >= _goalNumber)
            {
                return _points + _bonusPoints;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsDone()
    {
        return _completedNumber >= _goalNumber;
    }

    public override string GetSaveString()
    {
        return $"{_goalType}|{_name}|{_description}|{_points}|{_goalNumber}|{_bonusPoints}|{_completedNumber}";
    }
}