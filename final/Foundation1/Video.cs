using System;
using System.Collections.Generic;

public class Video
{
    
    private string author;
    private string title;
    private int length; // Length in seconds
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void AddComment(string name, string text)
    {
        comments.Add(new Comment(name, text));
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
    }

    public void DisplayComments()
    {
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine(comment.GetCommentText());
        }
    }
}
