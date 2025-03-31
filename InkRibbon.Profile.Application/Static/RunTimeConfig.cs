using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace ink_ribbon_profile_api.Application.Static
{
    public static class RunTimeConfig
    {
        public static string? Auroraconnection;
        public static string? Mongoconnection = "";
        public static string SteamEndpoint = "https://api.steampowered.com";
        public static string XboxEndpoint = "https://xbl.io/api";
        public static string SteamKey = "7EF68DF4509300363D18904036C9C169";
        public static string XboxKey = "634d98c7-17ca-48e5-b260-1bd87feaaac9";

        public static void SetConfigs(ConfigurationManager configuration)
        {
            if (Debugger.IsAttached)
            {
                Auroraconnection = "host=localhost;Database=postgres;username=postgres;password=12345678;";
                Mongoconnection = configuration.GetConnectionString("Mongoconnection");
            }
            else
            {
                Auroraconnection = Environment.GetEnvironmentVariable("Auroraconnection");
                Mongoconnection = Environment.GetEnvironmentVariable("Mongoconnection");
            }
        }

    }
}
