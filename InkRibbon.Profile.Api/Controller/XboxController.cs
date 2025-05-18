using ink_ribbon_profile_api.Application.Services;
using ink_ribbon_profile_api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ink_ribbon_profile_api.Controller
{
    [ApiController]
    [EnableCors("All")]
    public class XboxController : ControllerBase
    {
        private readonly ILogger<XboxController> _logger;
        private readonly IXboxService _xboxAchievementService;

        public XboxController(ILogger<XboxController> logger, IXboxService xboxAchievementService)
        {
            _logger = logger;
            _xboxAchievementService = xboxAchievementService;
        }

        [HttpGet("GetAchievements")]
        public async Task<IActionResult> GetAchievements()
        {
            //var command = new GetConditionsQuery(assetId);
            var user = await _xboxAchievementService.GetAchievements();

            return Ok(user);
        }

        [HttpGet("GetAchievementsById")]
        public async Task<IActionResult> GetAchievementsById(string xuid)
        {
            //var command = new GetConditionsQuery(assetId);
            var user = await _xboxAchievementService.GetAchievementsById(xuid);

            return Ok(user);
        }



    }
}