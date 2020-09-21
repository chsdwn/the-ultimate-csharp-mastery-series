using System;

namespace ultimate_csharp_mastery
{
    public class Post
    {
        public int Vote { get; private set; }

        private string _title;
        private string _description;
        private DateTime _createdAt;

        public Post(string title, string description, DateTime createdAt)
        {
            _title = title;
            _description = description;
            _createdAt = createdAt;
        }

        public void Upvote()
        {
            ++Vote;
        }

        public void Downvote()
        {
            --Vote;
        }
    }
}