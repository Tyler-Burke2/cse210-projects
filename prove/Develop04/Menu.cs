using System;

namespace MindfulnessApp
{
    public class Menu
    {
        private string menuString = @"
            Mindfulness Activities
            ----------------------
            1. Breathing Activity
            2. Reflection Activity
            3. Listing Activity
            4. Exit
            Select a choice from the menu: ";

        private int userInput;

        public void DisplayMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.Write(menuString);

                string input = Console.ReadLine();
                if (int.TryParse(input, out userInput))
                {
                    Activities activity = null;

                    switch (userInput)
                    {
                        case 1:
                            activity = new BreathingActivity();
                            break;
                        case 2:
                            activity = new ReflectionActivity();
                            break;
                        case 3:
                            activity = new ListingActivity();
                            break;
                        case 4:
                            Console.WriteLine("Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }

                    if (activity != null)
                    {
                        activity.DisplayInfo();
                        activity.DisplayEnd();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number.");
                }

                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}
