using System;
using System.Threading;

namespace MindfulnessApp
{
    public class Activities
    {
        protected string intro;
        protected string description;
        protected string endMessage;
        protected int secondCount;
        protected int pause;

        public virtual void DisplayInfo()
        {
            Console.Clear();
            Console.WriteLine(intro);
            Console.WriteLine(description);
            Console.Write("\nHow long would you like this activity to last (in seconds)? ");
            secondCount = int.Parse(Console.ReadLine());

            Console.WriteLine("\nGet ready...");
            DisplayAnimation(3);
            Console.Clear();
        }

        public void DisplayCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
                Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            }
        }

        public void DisplayAnimation(int seconds)
        {
            char[] spinner = { '|', '/', '-', '\\' };
            int counter = 0;
            DateTime endTime = DateTime.Now.AddSeconds(seconds);

            while (DateTime.Now < endTime)
            {
                Console.Write(spinner[counter % spinner.Length]);
                Thread.Sleep(200);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                counter++;
            }
        }

        public virtual void DisplayEnd()
        {
            Console.Clear();
            Console.WriteLine(endMessage);
            Console.WriteLine($"You completed {secondCount} seconds of the {GetType().Name}!");
            DisplayAnimation(3);
        }

        public int GetSecondsCount() => secondCount;
        public int GetPause() => pause;
    }
}
