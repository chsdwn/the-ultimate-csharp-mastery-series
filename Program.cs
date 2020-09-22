using System;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("sql");
            var sqlCommand = new DbCommand(sql, "SELECT * FROM tblSql");
            sqlCommand.Execute();

            var oracle = new OracleConnection("oracle");
            var oracleCommand = new DbCommand(oracle, "SELECT * FROM tblOracle");
            oracleCommand.Execute();
        }
    }
}
