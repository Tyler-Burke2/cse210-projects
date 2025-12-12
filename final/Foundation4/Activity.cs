using System;
 
public class Activity
{
    private string _date;
    private int _minutes;

    private static string _unit = "m";

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public static void SetUnit(string unitChoice)
    {
        if (string.IsNullOrWhiteSpace(unitChoice)) return;
        unitChoice = unitChoice.Trim().ToLower();
        if (unitChoice == "km" || unitChoice == "k" || unitChoice == "kilometers" || unitChoice == "kilometres")
            _unit = "km";
        else
            _unit = "m";
    }

    public static string GetUnit()
    {
        return _unit;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        double distance = GetDistance();
        if (_minutes <= 0 || distance <= 0) return 0.0;
        return (distance / _minutes) * 60.0;
    }

    public virtual double GetPace()
    {
        double distance = GetDistance();
        if (distance <= 0) return 0.0;
        return _minutes / distance;
    }

    public string GetSummary()
    {
        string unitLabelDistance = _unit == "km" ? "km" : "miles";
        string unitLabelSpeed = _unit == "km" ? "kph" : "mph";
        string unitLabelPace = _unit == "km" ? "min per km" : "min per mile";

        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{_date} {this.GetType().Name} ({_minutes} min) - Distance {distance:0.0} {unitLabelDistance}, Speed {speed:0.0} {unitLabelSpeed}, Pace {pace:0.0} {unitLabelPace}";
    }
}