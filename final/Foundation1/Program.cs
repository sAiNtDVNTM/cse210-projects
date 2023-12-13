using System;
class Program
{
    static void Main(string[] args)
    {
        // Create videos and add comments
        Video video1 = new Video("Video 1", "Author 1", 300);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "I learned a lot.");

        Video video2 = new Video("Video 2", "Author 2", 450);
        video2.AddComment("User3", "Nice content!");
        video2.AddComment("User4", "Could you explain this part more?");

        // Put videos in a list
        List<Video> videoList = new List<Video> { video1, video2 };

        // Iterate through the list and display video details
        foreach (var video in videoList)
        {
            video.DisplayVideoDetails();
        }
    }
}
