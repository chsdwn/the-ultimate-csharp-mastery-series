using System;

namespace ultimate_csharp_mastery
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending text message... " + e.Video.Title);
        }
    }
}