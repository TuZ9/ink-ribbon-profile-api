using ink_ribbon_profile_consumer.Application.Services;
using ink_ribbon_profile_consumer.Domain.Dto.Steam;
using ink_ribbon_profile_consumer.Domain.Interfaces.ApiClientService.Steam;

namespace ink_ribbon_profile_consumer.Infra.HttpClientBase.Steam
{
    public class SteamUserApiClient : ServiceClientBase<SteamUserDto, SteamUserApiClient>, ISteamUserApiClient
    {
        public SteamUserApiClient(HttpClient clientFactory, ILogger<SteamUserApiClient> logger) : base(clientFactory, logger)
        {
        }
    }
}
