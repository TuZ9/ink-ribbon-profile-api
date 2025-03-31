using ink_ribbon_profile_consumer.Application.Services;
using ink_ribbon_profile_consumer.Domain.Interfaces.Services;

namespace ink_ribbon_profile_consumer.Infra.Extensions
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
                .AddScoped<IXboxAchievementService, XboxAchievementService>();
        }
    }
}
