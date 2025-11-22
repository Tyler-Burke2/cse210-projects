public class Goals
{
    protected string _goalType;
    protected int _points;
    protected string _name;
    protected string _description;
    protected List<string> _goals;

    public Goals()
    {
        _goalType = "";
        _points = 0;
        _name = "";
        _description = "";
        _goals = new List<string>();
    }

    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    public virtual int SetPoints()
    {
        return _points;
    }

    public virtual bool IsDone()
    {
        return false;
    }

    public virtual void DisplayScore()
    {
        Console.WriteLine($"Goal: {_name} - {_points} points");
    }

    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual string GetSaveString()
    {
        return $"{_goalType}|{_name}|{_description}|{_points}";
    }
}