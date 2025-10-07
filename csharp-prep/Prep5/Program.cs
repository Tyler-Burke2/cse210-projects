using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine("What is your full name?");
        string name = Console.ReadLine();
        Console.WriteLine("What is your favorite number? ");
        string number = Console.ReadLine();
        int Num = 0;
        Num = int.Parse(number);
        int square = Num * Num;
        Console.WriteLine("What year were you born? ");
        string birth = Console.ReadLine();
        int Numb = int.Parse(birth);
        int Age = 2025 - Numb;
        Console.WriteLine($"{name}, the square of your number is: {square}");
        Console.WriteLine($"{name}, you will turn {Age} this year.");
    }
}