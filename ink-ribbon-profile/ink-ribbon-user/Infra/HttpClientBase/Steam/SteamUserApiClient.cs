using ink_ribbon_profile.Application.Services;
using ink_ribbon_profile.Domain.Dto.Steam;
using ink_ribbon_profile.Domain.Interfaces.ApiClientService.Steam;

namespace ink_ribbon_profile.Infra.HttpClientBase.Steam
{
    public class SteamUserApiClient : ServiceClientBase<SteamUserDto, SteamUserApiClient>, ISteamUserApiClient
    {
        public SteamUserApiClient(HttpClient clientFactory, ILogger<SteamUserApiClient> logger) : base(clientFactory, logger)
        {
        }
    }
}
