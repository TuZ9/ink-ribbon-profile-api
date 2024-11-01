using ink_ribbon_profile_api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ink_ribbon_profile_api.Controller
{
    [ApiController]
    [EnableCors("All")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly ISteamUserSevice _steamUserSevice;
        private readonly IXboxAchievementService _xboxAchievementService;

        public UserController(ILogger<UserController> logger, ISteamUserSevice steamUserSevice, IXboxAchievementService xboxAchievementService)
        {
            _logger = logger;
            _steamUserSevice = steamUserSevice;
            _xboxAchievementService = xboxAchievementService;
        }

        [HttpGet("steam/GetSteamIdByName")]
        public async Task<IActionResult> GetSteamIdByName(string steamName)
        {
            //var command = new GetConditionsQuery(assetId);
            var user = await _steamUserSevice.BuildSteamUser(steamName);
            return Ok(user);
        }

        [HttpGet("steam/GetUser")]
        public async Task<IActionResult> GetSteamUserById(string steamId)
        {
            //var command = new GetConditionsQuery(assetId);
            var user = await _steamUserSevice.GetSteamUserById(steamId);

            return Ok(user);
        }

        [HttpGet("Xbox/GetAchievements")]
        public async Task<IActionResult> GetAchievements()
        {
            //var command = new GetConditionsQuery(assetId);
            var user = await _xboxAchievementService.GetAchievements();

            return Ok(user);
        }

        [HttpGet("Xbox/GetAchievementsById")]
        public async Task<IActionResult> GetAchievementsById(string xuid)
        {
            //var command = new GetConditionsQuery(assetId);
            var user = await _xboxAchievementService.GetAchievementsById(xuid);

            return Ok(user);
        }
    }
}