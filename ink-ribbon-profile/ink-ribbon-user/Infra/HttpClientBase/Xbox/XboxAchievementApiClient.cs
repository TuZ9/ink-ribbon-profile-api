using ink_ribbon_profile.Application.Services;
using ink_ribbon_profile.Domain.Dto.Xbox;
using ink_ribbon_profile.Domain.Interfaces.ApiClientService.Xbox;

namespace ink_ribbon_profile.Infra.HttpClientBase.Xbox
{
    public class XboxAchievementApiClient : ServiceClientBase<AchievementDto, XboxAchievementApiClient>, IXboxAchievementApiClient
    {
        public XboxAchievementApiClient(HttpClient clientFactory, ILogger<XboxAchievementApiClient> logger) : base(clientFactory, logger)
        {
        }
    }
}