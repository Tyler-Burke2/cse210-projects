public class Menu
{
    private Prompt_Generation generator = new Prompt_Generation();
    private bool running = true;

    public void Start()
    {
        while (running)
        {
            Console.WriteLine("Time to journal!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What number do you pick? ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number == 1)
            {
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine("Your writing prompt is:");
                Console.WriteLine(prompt);

                Console.WriteLine("Write your response:");
                string response = Console.ReadLine();

                Console.WriteLine("Thanks for writing!");
            }
            else if (number == 2)
            {
                Console.WriteLine("Displaying all past journal entries...");
            }
            else if (number == 3)
            {
                Console.WriteLine("Loading...");
            }
            else if (number == 4)
            {
                Console.WriteLine("Saving...");
            }
            else if (number == 5)
            {
                Console.WriteLine("Quitting program...");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid selection, please choose a whole number from 1 to 5.");
            }

            Console.WriteLine();
        }
    }
}