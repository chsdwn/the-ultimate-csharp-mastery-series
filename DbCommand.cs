using System;

namespace ultimate_csharp_mastery
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _command;

        public DbCommand(DbConnection dbConnection, string command)
        {
            if (String.IsNullOrEmpty(command) || String.IsNullOrWhiteSpace(command))
                throw new ArgumentException("Command cannot be empty.");

            _dbConnection = dbConnection;
            _command = command;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine(_command + " executed.");
            _dbConnection.Close();
        }
    }
}