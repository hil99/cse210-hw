using System;
using System.Collections.Generic;

public class Video
{
    // Attributes
    private string title;
    private string author;
    private int length; // Length in minutes
    private List<Comment> comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>();
    }

    // Methods
    public void PlayVideo()
    {
        Console.WriteLine($"Playing video: {title} by {author}");
    }

    public void PauseVideo()
    {
        Console.WriteLine($"Video paused: {title}");
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void AddComment(string name, string text)
    {
        comments.Add(new Comment(name, text));
        Console.WriteLine("Comment added!");
    }

    public void DisplayComments()
    {
        Console.WriteLine($"Comments for {title}:");
        foreach (var comment in comments)
        {
            Console.WriteLine($"{comment.GetCommentText()}");
        }
    }
}
