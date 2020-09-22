using System;

namespace ultimate_csharp_mastery
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Sql connection opened");
        }

        public override void Close()
        {
            Console.WriteLine("Sql connection closed");
        }
    }
}