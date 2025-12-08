using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("Nature Walk", "Tyler Burke", 215);

        video.AddComment(new Comment("Sarah", "Loved the scenery!"));
        video.AddComment(new Comment("Jake", "Great editing."));
        video.AddComment(new Comment("Mia", "Very relaxing video."));

        video.DisplayVideo();
    }
}
