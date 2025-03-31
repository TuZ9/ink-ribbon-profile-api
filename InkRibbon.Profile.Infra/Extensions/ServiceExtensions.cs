﻿using ink_ribbon_profile_api.Application.Services;
using ink_ribbon_profile_api.Domain.Interfaces.Services;
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
                .AddScoped<ISteamUserSevice, SteamUserService>()
                .AddScoped<IXboxAchievementService, XboxAchievementService>();
        }
    }
}
