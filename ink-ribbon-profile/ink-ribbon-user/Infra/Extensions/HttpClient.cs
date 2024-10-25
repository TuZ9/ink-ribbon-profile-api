using ink_ribbon_profile.Application.Static;
using ink_ribbon_profile.Domain.Interfaces.ApiClientService.Steam;
using ink_ribbon_profile.Domain.Interfaces.ApiClientService.Xbox;
using ink_ribbon_profile.Infra.HttpClientBase.Steam;
using ink_ribbon_profile.Infra.HttpClientBase.Xbox;

namespace ink_ribbon_profile.Infra.Extensions
{
    public static class HttpClient
    {
        public static IServiceCollection AddHttpClients(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            
            services.AddHttpClient<ISteamUserApiClient, SteamUserApiClient>(_ => _.BaseAddress = new Uri(RunTimeConfig.SteamEndpoint));
            services.AddHttpClient<IXboxLastSeenApiClient, XboxLastSeenApiClient>(_ => _.BaseAddress = new Uri(RunTimeConfig.XboxEndpoint));
            services.AddHttpClient<IXboxUserApiClient, XboxUserApiClient>(_ => _.BaseAddress = new Uri(RunTimeConfig.XboxEndpoint));

            return services;
        }
    }
}