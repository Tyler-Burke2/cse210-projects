using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Use miles or kilometers? (m/km)");
        string unit = Console.ReadLine().ToLower();

        Activity.SetUnit(unit);

        List<Activity> activities = new List<Activity>();

        Console.WriteLine("How many activities?");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nChoose activity:");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Cycling");
            Console.WriteLine("3. Swimming");

            int option = int.Parse(Console.ReadLine());

            Console.WriteLine("Date (MM/DD/YYYY):");
            string date = Console.ReadLine();

            Console.WriteLine("Length in minutes:");
            int minutes = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Distance:");
                double dist = double.Parse(Console.ReadLine());

                activities.Add(new Running(date, minutes, dist));
            }
            else if (option == 2)
            {
                Console.WriteLine("Speed:");
                double speed = double.Parse(Console.ReadLine());

                activities.Add(new Cycling(date, minutes, speed));
            }
            else if (option == 3)
            {
                Console.WriteLine("Laps:");
                int laps = int.Parse(Console.ReadLine());

                activities.Add(new Swimming(date, minutes, laps));
            }
        }

        Console.WriteLine("\n=== ACTIVITY SUMMARIES ===");

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
