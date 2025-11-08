using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class ListingActivity : Activities
    {
        private List<string> prompts;
        private Random random = new Random();

        public ListingActivity()
        {
            intro = "Welcome to the Listing Activity!";
            description = "List as many things as you can in a certain area of positivity.";
            endMessage = "Well done! You’ve focused your thoughts in a great way.";

            prompts = new List<string>
            {
                "List as many things as you are grateful for.",
                "List the people who make you feel happy.",
                "List experiences that brought you peace."
            };
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            DisplayPrompt();
        }

        public void DisplayPrompt()
        {
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine($"\n--- {prompt} ---");
            Console.WriteLine("You have a few seconds to think...");
            DisplayAnimation(5);

            Console.WriteLine("\nStart listing items:");
            List<string> responses = new List<string>();

            DateTime endTime = DateTime.Now.AddSeconds(secondCount);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                responses.Add(Console.ReadLine());
            }

            Console.WriteLine($"\nYou listed {responses.Count} items!");
        }
    }
}
