using ink_ribbon_profile_api.Application.Services;
using ink_ribbon_profile_api.Domain.Dto.Steam;
using ink_ribbon_profile_api.Domain.Interfaces.ApiClientService.Steam;
using Microsoft.Extensions.Logging;

namespace ink_ribbon_profile_api.Infra.HttpClientBase.Steam
{
    public class SteamUserApiClient : ServiceClientBase<SteamUserDto, SteamUserApiClient>, ISteamUserApiClient
    {
        public SteamUserApiClient(HttpClient clientFactory, ILogger<SteamUserApiClient> logger) : base(clientFactory, logger)
        {
        }
    }
}
