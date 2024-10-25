using ink_ribbon_profile.Application.Static;
using Npgsql;
using System.Data;

namespace ink_ribbon_profile.Infra.Context
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