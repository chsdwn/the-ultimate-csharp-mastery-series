using System;

namespace ultimate_csharp_mastery
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending mail... " + e.Video.Title);
        }
    }
}