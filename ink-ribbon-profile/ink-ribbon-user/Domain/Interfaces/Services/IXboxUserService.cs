using ink_ribbon_profile.Domain.Dto.Xbox;

namespace ink_ribbon_profile.Domain.Interfaces.Services
{
    public interface IXboxAchievementService
    {
        Task<AchievementDto> GetAchievementsById(string xuid);
        Task<AchievementDto> GetAchievements();
        Task<AchievementDto> GetAchievementsByIdGame(string xuid, string titleId);
        Task<AchievementDto> GetAchievementsByIdGame360(string xuid, string titleId);
    }
}