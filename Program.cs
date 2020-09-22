using System;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("sql");
            sql.Open();
            sql.Close();

            var oracle = new OracleConnection("oracle");
            oracle.Open();
            oracle.Close();
        }
    }
}
