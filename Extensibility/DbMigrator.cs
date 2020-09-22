using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.UtcNow + "(UTC)");
            _logger.LogInfo("Migration finished at " + DateTime.UtcNow + "(UTC)");
        }
    }
}