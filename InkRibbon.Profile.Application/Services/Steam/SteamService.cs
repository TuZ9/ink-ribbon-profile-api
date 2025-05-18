using ink_ribbon_profile_api.Application.Static;
using ink_ribbon_profile_api.Domain.Dto.Steam;
using ink_ribbon_profile_api.Domain.Interfaces.ApiClientService.Steam;
using ink_ribbon_profile_api.Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;

namespace InkRibbon.Profile.Application.Services.Steam
{
    public class SteamService : ISteamSevice
    {
        private readonly ILogger<SteamService> _logger;
        private readonly ISteamUserApiClient _steamClient;

        public SteamService(ILogger<SteamService> logger, ISteamUserApiClient steamClient)
        {
            _logger = logger;
            _steamClient = steamClient;
        }

        public async Task<SteamUserDto> BuildSteamUser(string userName)
        {
            try
            {
                var steamId = await GetSteamIdByName(userName);
                var steamUser = await GetSteamUserById(steamId.response.steamid);
                return steamUser;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error Message {0}", ex.Message);
                throw;
            }
        }

        public async Task<SteamUserDto> GetSteamIdByName(string userName)
        {
            try
            {
                var user = await _steamClient.GetAsync($"/ISteamUser/ResolveVanityURL/v1/?key={RunTimeConfig.SteamKey}&vanityurl={userName}");

                return user;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error Message {0}", ex.Message);
                throw;
            }
        }

        public async Task<SteamUserDto> GetSteamUserById(string steamId)
        {
            try
            {
                var user = await _steamClient.GetAsync($"/ISteamUser/GetPlayerSummaries/v0002/?key={RunTimeConfig.SteamKey}&steamids={steamId}");

                return user;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error Message {0}", ex.Message);
                throw;
            }
        }
    }
}
