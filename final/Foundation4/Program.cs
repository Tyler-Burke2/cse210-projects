using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Activity Tracker ===");

        Console.Write("Enter date: ");
        string date = Console.ReadLine();

        Console.Write("Enter minutes: ");
        int minutes = int.Parse(Console.ReadLine());

        Console.WriteLine("\nSelect Activity Type:");
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Cycling");
        Console.WriteLine("3. Swimming");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Activity activity;

        if (choice == "1")
        {
            Console.Write("Enter distance (miles): ");
            double distance = double.Parse(Console.ReadLine());
            activity = new Running(date, minutes, distance);
        }
        else if (choice == "2")
        {
            Console.Write("Enter speed (mph): ");
            double speed = double.Parse(Console.ReadLine());
            activity = new Cycling(date, minutes, speed);
        }
        else
        {
            Console.Write("Enter number of laps: ");
            int laps = int.Parse(Console.ReadLine());
            activity = new Swimming(date, minutes, laps);
        }

        Console.WriteLine("\n=== ACTIVITY SUMMARY ===");
        Console.WriteLine(activity.GetSummary());
    }
}
