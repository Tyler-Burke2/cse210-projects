public class Event
{
    private string _filename;
    private string _outputFile;
    private List<Goals> _goals;
    private int _score;
    private int _level;

    public Event()
    {
        _filename = "goals.txt";
        _outputFile = "goals.txt";
        _goals = new List<Goals>();
        _score = 0;
        _level = 1;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYou have {_score} points. (Level {_level}: {GetLevelTitle()})");
    }

    private string GetLevelTitle()
    {
        return _level switch
        {
            1 => "Beginner",
            2 => "Apprentice",
            3 => "Achiever",
            4 => "Champion",
            5 => "Hero",
            _ => "Legend"
        };
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nTypes of Goals:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string type = Console.ReadLine();
        Goals newGoal = null;

        switch (type)
        {
            case "1":
                newGoal = new SimpleGoal();
                break;
            case "2":
                newGoal = new EternalGoal();
                break;
            case "3":
                newGoal = new ChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        newGoal.CreateGoal();
        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals created yet.");
            return;
        }

        Console.WriteLine("\nYour Goals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsDone() ? "[X]" : "[ ]";

            string extra = "";
            if (_goals[i] is ChecklistGoal checklistGoal)
            {
                extra = $" -- Completed {checklistGoal.IsDoneTimes()}";
            }

            Console.WriteLine($"{i + 1}. {status} {_goals[i].GetName()}: {_goals[i].GetDescription()} ({_goals[i].GetPoints()} pts){extra}");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals to record. Create some goals first!");
            return;
        }

        ListGoals();
        Console.Write("\nWhich goal did you accomplish? ");

        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
        {
            Goals goal = _goals[index - 1];
            int pointsEarned = goal.SetPoints();

            int oldLevel = _level;
            _score += pointsEarned;
            _level = (_score / 1000) + 1;

            if (pointsEarned > 0)
            {
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points.");

                if (_level > oldLevel)
                {
                    Console.WriteLine($"\nLEVEL UP! You are now Level {_level}: {GetLevelTitle()}!");
                }
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(_outputFile))
        {
            writer.WriteLine($"{_score}|{_level}");

            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadFromFile()
    {
        if (!File.Exists(_filename))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(_filename);

        string[] userData = lines[0].Split('|');
        _score = int.Parse(userData[0]);
        _level = int.Parse(userData[1]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            Goals goal = null;

            switch (type)
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                    break;
                case "ChecklistGoal":
                    goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                        int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                    break;
            }

            if (goal != null) _goals.Add(goal);
        }

        Console.WriteLine($"Goals loaded successfully! Found {_goals.Count} goals.");
    }
}