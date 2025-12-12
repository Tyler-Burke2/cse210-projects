using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Event Creator ===");
        Console.Write("Enter title: ");
        string title = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter date: ");
        string date = Console.ReadLine();

        Console.Write("Enter time: ");
        string time = Console.ReadLine();

        Console.WriteLine("\n--- Address Info ---");
        Console.Write("Street: ");
        string street = Console.ReadLine();

        Console.Write("City: ");
        string city = Console.ReadLine();

        Console.Write("State/Province: ");
        string state = Console.ReadLine();

        Console.Write("Country: ");
        string country = Console.ReadLine();

        Address address = new Address(street, city, state, country);

        Console.WriteLine("\nSelect Event Type:");
        Console.WriteLine("1. Lecture");
        Console.WriteLine("2. Reception");
        Console.WriteLine("3. Outdoor Gathering");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Event finalEvent;

        if (choice == "1")
        {
            Console.Write("Enter speaker name: ");
            string speaker = Console.ReadLine();

            Console.Write("Enter capacity (number): ");
            int capacity = int.Parse(Console.ReadLine());

            finalEvent = new Lecture(title, description, date, time, address, speaker, capacity);
        }
        else if (choice == "2")
        {
            Console.Write("Enter RSVP email: ");
            string email = Console.ReadLine();

            finalEvent = new Reception(title, description, date, time, address, email);
        }
        else
        {
            Console.Write("Enter weather forecast: ");
            string forecast = Console.ReadLine();

            finalEvent = new OutdoorGathering(title, description, date, time, address, forecast);
        }

        Console.WriteLine("\n=== EVENT CREATED ===");
        Console.WriteLine(finalEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(finalEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(finalEvent.GetShortDescription());
    }
}
