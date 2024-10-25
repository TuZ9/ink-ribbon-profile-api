using ink_ribbon_profile.Application.Services;
using ink_ribbon_profile.Domain.Interfaces.Services;

namespace ink_ribbon_profile.Infra.Extensions
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
                .AddScoped<ISteamUserSevice, SteamUserService>()
                .AddScoped<IXboxUserService, XboxUserService>();
        }
    }
}
