public class Activity
{
    private string date;
    private int minutes;

    public Activity(string date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public string GetDate()
    {
        return date;
    }

    public int GetMinutes()
    {
        return minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / minutes) * 60;
    }

    public virtual double GetPace()
    {
        double distance = GetDistance();
        return minutes / distance;
    }

    public string GetSummary()
    {
        return $"{date} {this.GetType().Name} ({minutes} min) - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}
