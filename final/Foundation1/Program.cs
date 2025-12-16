using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== YOUTUBE VIDEO TRACKER ===\n");

        Video video1 = new Video("C# Programming Tutorial", "CodeAcademy", 1200);
        video1.AddComment(new Comment("Alice", "Great tutorial! Very helpful."));
        video1.AddComment(new Comment("Bob", "Thanks!"));
        video1.AddComment(new Comment("Charlie", "This explained everything I needed to know about classes."));
        video1.AddComment(new Comment("Diana", "Clear and concise."));

        Video video2 = new Video("Advanced OOP Concepts", "TechGuru", 1800);
        video2.AddComment(new Comment("Eve", "Mind blown by polymorphism!"));
        video2.AddComment(new Comment("Frank", "Best explanation of inheritance I've seen."));
        video2.AddComment(new Comment("Grace", "Excellent!"));

        Video video3 = new Video("Building Your First App", "DevMaster", 2400);
        video3.AddComment(new Comment("Henry", "Following along step by step."));
        video3.AddComment(new Comment("Iris", "This is exactly what I needed for my project. Thank you so much!"));
        video3.AddComment(new Comment("Jack", "Good stuff."));
        video3.AddComment(new Comment("Karen", "Very practical approach."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine("=================================");
            video.DisplayVideo();
            Console.WriteLine();

            List<Comment> comments = video.GetComments();
            if (comments.Count > 0)
            {
                Comment longest = comments[0];
                Comment shortest = comments[0];

                foreach (Comment c in comments)
                {
                    if (c.GetText().Length > longest.GetText().Length)
                        longest = c;

                    if (c.GetText().Length < shortest.GetText().Length)
                        shortest = c;
                }

                Console.WriteLine("Longest Comment:");
                Console.WriteLine($"   Author: {longest.GetAuthor()}");
                Console.WriteLine($"   Text: \"{longest.GetText()}\"");

                Console.WriteLine("\nShortest Comment:");
                Console.WriteLine($"   Author: {shortest.GetAuthor()}");
                Console.WriteLine($"   Text: \"{shortest.GetText()}\"");
            }
            Console.WriteLine();
        }

        Console.WriteLine("=================================");
        Console.WriteLine($"\nTotal Videos Tracked: {videos.Count}");
    }
}