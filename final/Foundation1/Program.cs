using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Add videos and comments
        Video video1 = new Video("C# Tutorial", "Hilvin Kumar", 300);
        video1.AddComment("John", "Great tutorial!");
        video1.AddComment("Alice", "Very helpful, thank you.");
        video1.AddComment("Bob", "This made my day!");

        Video video2 = new Video("Learn Java", "Jane Smith", 420);
        video2.AddComment("Charlie", "Amazing content!");
        video2.AddComment("Sophia", "Thanks for sharing.");

        Video video3 = new Video("Python Basics", "Alex Brown", 600);
        video3.AddComment("Eve", "So clear and concise!");
        video3.AddComment("Liam", "Can't wait for more videos.");

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display all videos and their comments
        foreach (var video in videos)
        {
            video.DisplayDetails();
            video.DisplayComments();
            Console.WriteLine(); // Add spacing between videos
        }
    }
}
