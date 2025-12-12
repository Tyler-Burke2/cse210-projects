using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments ({GetNumberOfComments()}):");
        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }
    }

    public List<Comment> GetComments()
    {
        return new List<Comment>(_comments);
    }

    public string GetTitle() => _title;
    public string GetAuthor() => _author;
    public int GetLength() => _length;
}