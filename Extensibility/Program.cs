using System;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("./Log.txt"));
            dbMigrator.Migrate();
        }
    }
}
