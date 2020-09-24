using System;

namespace ultimate_csharp_mastery
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}