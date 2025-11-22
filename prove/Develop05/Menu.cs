public class Menu
{
    private string _menu;
    private Event _eventManager;

    public Menu()
    {
        _eventManager = new Event();
        _menu = @"
Menu Options:
  1. Create New Goal
  2. List Goals
  3. Save Goals
  4. Load Goals
  5. Record Event
  6. Quit";
    }

    public void Display()
    {
        bool running = true;

        Console.WriteLine("\n=== ETERNAL QUEST ===");
        Console.WriteLine("Your Journey to Excellence\n");

        while (running)
        {
            _eventManager.DisplayScore();
            Console.WriteLine(_menu);
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": _eventManager.CreateGoal(); break;
                case "2": _eventManager.ListGoals(); break;
                case "3": _eventManager.SaveToFile(); break;
                case "4": _eventManager.LoadFromFile(); break;
                case "5": _eventManager.RecordEvent(); break;
                case "6": running = false; break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        Console.WriteLine("\nGoodbye! Keep working on your goals!");
    }
}