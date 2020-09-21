using System;
using System.Collections.Generic;
using System.IO;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var dbMigrator = new DbMigrator(logger);
            dbMigrator.Migrate();

            var installer = new Installer(new Logger());
            installer.Install();
        }
    }
}
