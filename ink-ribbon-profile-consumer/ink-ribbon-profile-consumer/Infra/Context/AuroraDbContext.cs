using ink_ribbon_profile_consumer.Application.Static;
using Npgsql;
using System.Data;

namespace ink_ribbon_profile_consumer.Infra.Context
{
    public class AuroraDbContext : IDisposable
    {

        public AuroraDbContext()
        {
        }

        public IDbConnection CreateConnection()
            => new NpgsqlConnection(RunTimeConfig.Auroraconnection);

        public void Dispose()
        {
        }
    }
}