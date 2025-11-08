using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class ReflectionActivity : Activities
    {
        private List<string> prompts;
        private List<string> questions;
        private Random random = new Random();

        public ReflectionActivity()
        {
            intro = "Welcome to the Reflection Activity!";
            description = "Reflect on times when you have shown strength and resilience.";
            endMessage = "You’ve gained valuable insight through reflection.";

            prompts = new List<string>
            {
                "Think of a time you helped someone in need.",
                "Recall a moment when you overcame a challenge.",
                "Remember an experience that made you feel proud."
            };

            questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "What did you learn about yourself?",
                "How can you apply what you learned in the future?",
                "What did you do to stay calm or focused during that moment?",
                "How can this experience help you handle future challenges?"
            };
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            DisplayPrompt();
            DisplayQuestions();
        }

        public void DisplayPrompt()
        {
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine($"\n--- {prompt} ---");
            Console.WriteLine("Take a few moments to think about it...");
            DisplayAnimation(5);
        }

        public void DisplayQuestions()
        {
            DateTime endTime = DateTime.Now.AddSeconds(secondCount);

            while (DateTime.Now < endTime)
            {
                string question = questions[random.Next(questions.Count)];
                Console.WriteLine($"\n{question}");
                Console.Write("> ");

                // Wait for user to type a thoughtful response
                string response = Console.ReadLine();

                Console.WriteLine("Thank you for reflecting on that.");
                DisplayAnimation(2);

                // Optional: short pause before next question
                Console.WriteLine();
            }
        }
    }
}
