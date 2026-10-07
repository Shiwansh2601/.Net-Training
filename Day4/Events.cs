
using System;

class YouTubeChannel
{
    // Declare an event
    public event Action<string> VideoUploaded;

    // Upload a video
    public void UploadVideo(string title)
    {
        Console.WriteLine("New video uploaded: " + title);

        // Trigger the event
        VideoUploaded?.Invoke(title);
    }
}

class Program
{
    static void Main()
    {
        YouTubeChannel channel = new YouTubeChannel();

        // Subscribe to the event
        channel.VideoUploaded += NotifySubscriber;

        // Upload a video
        channel.UploadVideo("Learn C# Events");

        // Unsubscribe from the event
        channel.VideoUploaded -= NotifySubscriber;
    }

    // Event handler
    static void NotifySubscriber(string title)
    {
        Console.WriteLine("Notification: New video - " + title);
    }
}
