using ink_ribbon_profile_consumer.Domain.Dto.Steam;
using ink_ribbon_profile_consumer.Domain.Entities;

namespace ink_ribbon_profile_consumer.Domain.Interfaces.Services
{
    public interface ISteamUserSevice
    {
        Task<SteamUser> GetSteamId();
        Task<SteamUserDto> GetSteamUserById(string steamId);
        Task<SteamUserDto> GetSteamIdByName(string userName);
        Task<SteamUserDto> BuildSteamUser(string userName);
    }
}