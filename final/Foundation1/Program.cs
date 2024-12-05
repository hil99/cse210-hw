using System;

class Program
{
    static void Main()
    {
        Video myVideo = new Video("C# Tutorial", "Hilvin Kumar", 30);
        myVideo.PlayVideo();
        myVideo.AddComment("John", "Great tutorial!");
        myVideo.AddComment("Alice", "Very helpful, thank you.");
        myVideo.DisplayComments();
    }
}