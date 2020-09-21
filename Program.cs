using System;
using System.Collections.Generic;
using System.IO;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("title", "description", DateTime.Now);
            post.Upvote();
            post.Upvote();
            post.Upvote();
            post.Upvote();
            post.Downvote();
            post.Downvote();
            Console.WriteLine(post.Vote);
        }
    }
}
