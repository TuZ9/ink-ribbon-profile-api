using ink_ribbon_profile_api.Domain.Dto.Xbox;

namespace ink_ribbon_profile_api.Domain.Interfaces.Services
{
    public interface IXboxService
    {
        Task<XboxUserDto> GetXboxUserByGamertag(string gamertag);
        Task<AchievementDto> GetAchievementsById(string xuid);
        Task<AchievementDto> GetAchievements();
        Task<AchievementDto> GetAchievementsByIdGame(string xuid, string titleId);
        Task<AchievementDto> GetAchievementsByIdGame360(string xuid, string titleId);
    }
}