using System;

namespace ultimate_csharp_mastery
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString) ||
                String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string cannot be null or empty");
            ConnectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();
    }
}