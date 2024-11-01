using ink_ribbon_profile_api.Application.Services;
using ink_ribbon_profile_api.Domain.Dto.Xbox;
using ink_ribbon_profile_api.Domain.Interfaces.ApiClientService.Xbox;

namespace ink_ribbon_profile_api.Infra.HttpClientBase.Xbox
{
    public class XboxAchievementApiClient : ServiceClientBase<AchievementDto, XboxAchievementApiClient>, IXboxAchievementApiClient
    {
        public XboxAchievementApiClient(HttpClient clientFactory, ILogger<XboxAchievementApiClient> logger) : base(clientFactory, logger)
        {
        }
    }
}