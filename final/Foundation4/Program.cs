using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== FITNESS ACTIVITY TRACKER ===\n");
        
        Console.WriteLine("=================================");
        Console.WriteLine("DISPLAYING IN MILES");
        Console.WriteLine("=================================\n");
        
        Activity.SetUnit("m");

        List<Activity> activitiesMiles = new List<Activity>
        {
            new Running("12/15/2025", 30, 3.0),
            new Cycling("12/16/2025", 45, 15.0),
            new Swimming("12/17/2025", 30, 20)
        };

        Console.WriteLine("Activity Summaries:");
        foreach (Activity a in activitiesMiles)
        {
            Console.WriteLine($"   {a.GetSummary()}");
        }

        Console.WriteLine("\n");

        Console.WriteLine("=================================");
        Console.WriteLine("DISPLAYING IN KILOMETERS");
        Console.WriteLine("=================================\n");
        
        Activity.SetUnit("km");

        List<Activity> activitiesKm = new List<Activity>
        {
            new Running("12/15/2025", 30, 3.0),
            new Cycling("12/16/2025", 45, 15.0),
            new Swimming("12/17/2025", 30, 20)
        };

        Console.WriteLine("🏃 Activity Summaries:");
        foreach (Activity a in activitiesKm)
        {
            Console.WriteLine($"   {a.GetSummary()}");
        }

        Console.WriteLine("\n");

        Console.WriteLine("=================================");
        Console.WriteLine("DETAILED ACTIVITY BREAKDOWN");
        Console.WriteLine("=================================\n");

        Activity.SetUnit("m");
        Running detailedRun = new Running("12/18/2025", 40, 5.0);

        Console.WriteLine($"Activity Type: Running");
        Console.WriteLine($"Date: {detailedRun.GetDate()}");
        Console.WriteLine($"Duration: {detailedRun.GetMinutes()} minutes");
        Console.WriteLine($"Distance: {detailedRun.GetDistance():0.0} miles");
        Console.WriteLine($"Speed: {detailedRun.GetSpeed():0.0} mph");
        Console.WriteLine($"Pace: {detailedRun.GetPace():0.0} min per mile");

        Console.WriteLine("\n");

        Console.WriteLine("=================================");
        Console.WriteLine("POLYMORPHISM DEMONSTRATION");
        Console.WriteLine("=================================\n");

        Console.WriteLine("All activities can be treated uniformly:\n");

        List<Activity> mixedActivities = new List<Activity>
        {
            new Running("12/19/2025", 25, 2.5),
            new Cycling("12/19/2025", 60, 18.0),
            new Swimming("12/19/2025", 45, 30),
            new Running("12/20/2025", 35, 4.0)
        };

        int activityCount = 1;
        foreach (Activity activity in mixedActivities)
        {
            Console.WriteLine($"{activityCount}. {activity.GetSummary()}");
            activityCount++;
        }

        Console.WriteLine($"\nTotal Activities Tracked: {mixedActivities.Count}");
    }
}