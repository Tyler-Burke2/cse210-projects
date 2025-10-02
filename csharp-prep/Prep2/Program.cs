using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What percentage is your grade?");
        string grade = Console.ReadLine();


        int number = int.Parse(grade);

        if (number >= 90)
        {
            Console.WriteLine("Your letter grade is: A");
            Console.WriteLine("Congrats on passing the class!");
        }
        else if (number >= 80)
        {
            Console.WriteLine("Your letter grade is: B");
            Console.WriteLine("Congrats on passing the class!");
        }
        else if (number >= 70)
        {
            Console.WriteLine("Your letter grade is: C");
            Console.WriteLine("Congrats on passing the class!");
        }
        else if (number >= 60)
        {
            Console.WriteLine("Your letter grade is: D");
            Console.WriteLine("Do better next time!");
        }
        else if (number < 60)
        {
            Console.WriteLine("Your letter grade is: F");
            Console.WriteLine("Do better next time!");
        }
    }
}