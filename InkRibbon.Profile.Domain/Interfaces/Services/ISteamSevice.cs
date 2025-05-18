using ink_ribbon_profile_api.Domain.Dto.Steam;
using ink_ribbon_profile_api.Domain.Entities;

namespace ink_ribbon_profile_api.Domain.Interfaces.Services
{
    public interface ISteamSevice
    {
        Task<SteamUserDto> GetSteamUserById(string steamId);
        Task<SteamUserDto> GetSteamIdByName(string userName);
        Task<SteamUserDto> BuildSteamUser(string userName);
    }
}