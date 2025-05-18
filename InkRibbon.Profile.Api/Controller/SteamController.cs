using ink_ribbon_profile_api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ink_ribbon_profile_api.Controller
{
    [ApiController]
    [EnableCors("All")]
    public class SteamController : ControllerBase
    {
        private readonly ILogger<SteamController> _logger;
        private readonly ISteamSevice _steamUserSevice;
        private readonly IXboxService _xboxAchievementService;

        public SteamController(ILogger<SteamController> logger, ISteamSevice steamUserSevice, IXboxService xboxAchievementService)
        {
            _logger = logger;
            _steamUserSevice = steamUserSevice;
            _xboxAchievementService = xboxAchievementService;
        }

        [HttpGet("GetSteamIdByName")]
        public async Task<IActionResult> GetSteamIdByName(string steamName)
        {
            //var command = new GetConditionsQuery(assetId);
            var user = await _steamUserSevice.BuildSteamUser(steamName);
            return Ok(user);
        }

        [HttpGet("GetUser")]
        public async Task<IActionResult> GetSteamUserById(string steamId)
        {
            //var command = new GetConditionsQuery(assetId);
            var user = await _steamUserSevice.GetSteamUserById(steamId);

            return Ok(user);
        }
    }
}