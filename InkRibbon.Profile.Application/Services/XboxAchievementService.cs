using ink_ribbon_profile_api.Application.Static;
using ink_ribbon_profile_api.Domain.Dto.Xbox;
using ink_ribbon_profile_api.Domain.Interfaces.ApiClientService.Xbox;
using ink_ribbon_profile_api.Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;

namespace ink_ribbon_profile_api.Application.Services
{
    public class XboxAchievementService : IXboxAchievementService
    {
        private readonly ILogger<XboxAchievementService> _logger;
        private readonly IXboxAchievementApiClient _xboxAchievementApiClient;
        public XboxAchievementService(ILogger<XboxAchievementService> logger, IXboxAchievementApiClient xboxAchievementApiClient)
        {
            _logger = logger;
            _xboxAchievementApiClient = xboxAchievementApiClient;
        }

        public async Task<AchievementDto> GetAchievementsByIdGame(string xuid, string titleId)
        {
            try
            {
                var achievement = await _xboxAchievementApiClient.SendAsync($"api/v2/achievements/player/{xuid}/{titleId}", RunTimeConfig.XboxKey);

                return achievement;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error Message {0}", ex.Message);
                throw;
            }
        }
        public async Task<AchievementDto> GetAchievementsByIdGame360(string xuid, string titleId)
        {
            try
            {
                var achievement = await _xboxAchievementApiClient.SendAsync($"api/v2/achievements/player/{xuid}/title/{titleId}", RunTimeConfig.XboxKey);

                return achievement;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error Message {0}", ex.Message);
                throw;
            }
        }

        public async Task<AchievementDto> GetAchievementsById(string xuid)
        {
            try
            {
                var achievement = await _xboxAchievementApiClient.SendAsync($"api/v2/achievements/player/{xuid}", RunTimeConfig.XboxKey);

                return achievement;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error Message {0}", ex.Message);
                throw;
            }
        }

        public async Task<AchievementDto> GetAchievements()
        {
            try
            {
                var achievement = await _xboxAchievementApiClient.SendAsync($"/api/v2/achievements", RunTimeConfig.XboxKey);

                return achievement;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error Message {0}", ex.Message);
                throw;
            }
        }
    }
}
