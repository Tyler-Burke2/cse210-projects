using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter video title:");
        string title = Console.ReadLine();

        Console.WriteLine("Enter video author:");
        string author = Console.ReadLine();

        Console.WriteLine("Enter video length in seconds:");
        int length = int.Parse(Console.ReadLine());

        Video video = new Video(title, author, length);

        Console.WriteLine("How many comments do you want to add?");
        int commentCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commentCount; i++)
        {
            Console.WriteLine($"Comment {i + 1} author:");
            string cAuthor = Console.ReadLine();

            Console.WriteLine($"Comment {i + 1} text:");
            string cText = Console.ReadLine();

            video.AddComment(new Comment(cAuthor, cText));
        }

        Console.WriteLine();
        Console.WriteLine("Video Information:");
        video.DisplayVideo();
    }
}
