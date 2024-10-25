using ink_ribbon_profile.Domain.Dto.Steam;
using ink_ribbon_profile.Domain.Entities;

namespace ink_ribbon_profile.Domain.Interfaces.Services
{
    public interface ISteamUserSevice
    {
        Task<SteamUser> GetSteamId();
        Task<SteamUserDto> GetSteamUserById(string steamId);
        Task<SteamUserDto> GetSteamIdByName(string userName);
        Task<SteamUserDto> BuildSteamUser(string userName);
    }
}