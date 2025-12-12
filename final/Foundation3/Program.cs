using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Console.WriteLine("Choose event type:");
        Console.WriteLine("1. Lecture");
        Console.WriteLine("2. Reception");
        Console.WriteLine("3. Outdoor Gathering");

        int option = int.Parse(Console.ReadLine());

        Console.WriteLine("Event title:");
        string title = Console.ReadLine();

        Console.WriteLine("Description:");
        string description = Console.ReadLine();

        Console.WriteLine("Date (MM/DD/YYYY):");
        string date = Console.ReadLine();

        Console.WriteLine("Time:");
        string time = Console.ReadLine();

        Console.WriteLine("Address - Street:");
        string street = Console.ReadLine();

        Console.WriteLine("Address - City:");
        string city = Console.ReadLine();

        Console.WriteLine("Address - State/Province:");
        string state = Console.ReadLine();

        Console.WriteLine("Address - Country:");
        string country = Console.ReadLine();

        Address addr = new Address(street, city, state, country);

        if (option == 1)
        {
            Console.WriteLine("Speaker:");
            string speaker = Console.ReadLine();

            Console.WriteLine("Capacity:");
            int capacity = int.Parse(Console.ReadLine());

            events.Add(new Lecture(title, description, date, time, addr, speaker, capacity));
        }
        else if (option == 2)
        {
            Console.WriteLine("RSVP Email:");
            string email = Console.ReadLine();

            events.Add(new Reception(title, description, date, time, addr, email));
        }
        else
        {
            Console.WriteLine("Weather Forecast:");
            string weather = Console.ReadLine();

            events.Add(new OutdoorGathering(title, description, date, time, addr, weather));
        }

        Console.WriteLine("\n=== EVENT DETAILS ===");

        foreach (Event ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }

        Console.WriteLine("Search events by date (MM/DD/YYYY):");
        string searchDate = Console.ReadLine();

        bool found = false;
        foreach (Event ev in events)
        {
            if (ev.GetDate() == searchDate)
            {
                Console.WriteLine("Event found:");
                Console.WriteLine(ev.GetShortDescription());
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No events found on that date.");
    }
}
