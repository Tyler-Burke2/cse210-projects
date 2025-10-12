using System;
using System.Collections.Generic;
using System.IO;

public class Menu
{
    private Prompt_Generation generator = new Prompt_Generation();
    private bool running = true;
    private List<Entry> entries = new List<Entry>();

    public void Start()
    {
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Time to journal!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What number do you pick? ");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("\nInvalid input. Please enter a number from 1 to 5.");
                Pause();
                continue;
            }

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            switch (number)
            {
                case 1:
                    WriteEntry();
                    break;

                case 2:
                    DisplayEntries();
                    break;

                case 3:
                    LoadEntries(documentsPath);
                    break;

                case 4:
                    SaveEntries(documentsPath);
                    break;

                case 5:
                    Console.WriteLine("Quitting program...");
                    running = false;
                    break;

                default:
                    Console.WriteLine("\nInvalid selection, please choose a number from 1 to 5.");
                    break;
            }

            if (running) Pause();
        }
    }

    private void WriteEntry()
    {
        string prompt = generator.GetRandomPrompt();
        Console.WriteLine("\nYour writing prompt is:");
        Console.WriteLine(prompt);

        Console.WriteLine("\nWrite your response:");
        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, response);
        entries.Add(entry);

        Console.WriteLine("\nThanks for writing!");
    }

    private void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("\nNo journal entries to display.");
            return;
        }

        Console.WriteLine("\n--- Your Journal Entries ---");
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    private void LoadEntries(string documentsPath)
    {
        Console.Write("Enter the filename to load (include .csv): ");
        string filename = Console.ReadLine();
        string fullPath = Path.Combine(documentsPath, filename);

        if (File.Exists(fullPath))
        {
            string[] lines = File.ReadAllLines(fullPath);
            entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 3)
                {
                    string date = parts[0].Trim();
                    string prompt = parts[1].Trim();
                    string response = string.Join(",", parts, 2, parts.Length - 2).Trim();

                    Entry entry = new Entry(prompt, response);
                    entry.Date = date;
                    entries.Add(entry);
                }
            }
            Console.WriteLine($"\nJournal loaded successfully from: {fullPath}");
        }
        else
        {
            Console.WriteLine("\nFile not found.");
        }
    }

    private void SaveEntries(string documentsPath)
    {
        Console.Write("Enter the filename to save as (include .csv): ");
        string filename = Console.ReadLine();
        string fullPath = Path.Combine(documentsPath, filename);

        using (StreamWriter outputFile = new StreamWriter(fullPath, append: true))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.Csv());
            }
        }

        Console.WriteLine($"\nJournal saved successfully to: {fullPath}");
        entries.Clear();
    }

    private void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}
