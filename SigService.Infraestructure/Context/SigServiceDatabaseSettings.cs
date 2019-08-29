using System;

namespace SigService.Infraestructure
{
    public class SigServiceDatabaseSettings : ISigServiceDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ISigServiceDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
