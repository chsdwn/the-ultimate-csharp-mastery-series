using System;
using System.Collections.Generic;

namespace ultimate_csharp_mastery
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                throw new Exception("Youtube api error");
            }
            catch (Exception e)
            {
                throw new YoutubeException("User couldn't be found.", e);
            }

            return new List<Video>();
        }
    }
}