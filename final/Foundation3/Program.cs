using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== EVENT MANAGEMENT SYSTEM ===\n");

        List<Event> events = new List<Event>();

        Address lectureAddress = new Address("100 University Ave", "Boston", "MA", "USA");
        Lecture lecture = new Lecture(
            "Introduction to Artificial Intelligence",
            "Learn the fundamentals of AI and machine learning",
            "12/20/2025",
            "2:00 PM",
            lectureAddress,
            "Dr. Emily Chen",
            150
        );
        events.Add(lecture);

        Address receptionAddress = new Address("500 Grand Plaza", "Chicago", "IL", "USA");
        Reception reception = new Reception(
            "Annual Tech Gala",
            "Celebrating innovation and networking with industry leaders",
            "12/20/2025",
            "7:00 PM",
            receptionAddress,
            "rsvp@techgala.com"
        );
        events.Add(reception);

        Address outdoorAddress = new Address("Central Park Meadow", "New York", "NY", "USA");
        OutdoorGathering outdoor = new OutdoorGathering(
            "Community Yoga Session",
            "Free outdoor yoga class for all skill levels",
            "12/21/2025",
            "8:00 AM",
            outdoorAddress,
            "Sunny, 72°F"
        );
        events.Add(outdoor);

        int eventNumber = 1;
        foreach (Event ev in events)
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"EVENT #{eventNumber}");
            Console.WriteLine("=================================\n");

            Console.WriteLine("STANDARD DETAILS:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("FULL DETAILS:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("SHORT DESCRIPTION:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();

            eventNumber++;
        }

        Console.WriteLine("=================================");
        Console.WriteLine("EVENT SEARCH BY DATE");
        Console.WriteLine("=================================\n");

        string searchDate = "12/20/2025";
        Console.WriteLine($"Searching for events on: {searchDate}\n");

        bool found = false;
        foreach (Event ev in events)
        {
            if (ev.GetDate() == searchDate)
            {
                Console.WriteLine("Event Found:");
                Console.WriteLine(ev.GetShortDescription());
                Console.WriteLine();
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No events found on that date.");

        Console.WriteLine($"\nTotal Events Managed: {events.Count}");
    }
}