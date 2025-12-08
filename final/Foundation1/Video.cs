using System;
using System.Collections.Generic;

public class Video
{
    private string title;
    private string author;
    private int length;   // seconds
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length} seconds");
        Console.WriteLine($"Comments ({GetNumberOfComments()}):");

        foreach (Comment c in comments)
        {
            c.DisplayComment();
        }
    }
}
