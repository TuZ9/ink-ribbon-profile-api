using ink_ribbon_profile_api.Domain.Interfaces.Services;
using InkRibbon.Profile.Application.Services.Steam;
using InkRibbon.Profile.Application.Services.Xbox;
using Microsoft.Extensions.DependencyInjection;

namespace ink_ribbon_profile_api.Infra.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .RegisterServices();
        }

        private static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            return services
                .AddScoped<ISteamSevice, SteamService>()
                .AddScoped<IXboxService, XboxService>();
        }
    }
}
