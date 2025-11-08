using System;
using System.Threading;

namespace MindfulnessApp
{
    public class BreathingActivity : Activities
    {
        private int breathingIn = 4;
        private int breathingOut = 6;

        public BreathingActivity()
        {
            intro = "Welcome to the Breathing Activity!";
            description = "This activity will help you relax by guiding you through slow breathing.";
            endMessage = "Great job staying calm and centered!";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            DisplayBreath();
        }

        public void DisplayBreath()
        {
            DateTime endTime = DateTime.Now.AddSeconds(secondCount);

            while (DateTime.Now < endTime)
            {
                Console.Write("Breathe in... ");
                DisplayCountdown(breathingIn);
                Console.WriteLine();

                Console.Write("Breathe out... ");
                DisplayCountdown(breathingOut);
                Console.WriteLine("\n");
            }
        }
    }
}
