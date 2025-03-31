using ink_ribbon_profile_consumer.Application.Services;
using ink_ribbon_profile_consumer.Domain.Dto.Xbox;
using ink_ribbon_profile_consumer.Domain.Interfaces.ApiClientService.Xbox;

namespace ink_ribbon_profile_consumer.Infra.HttpClientBase.Xbox
{
    public class XboxAchievementApiClient : ServiceClientBase<AchievementDto, XboxAchievementApiClient>, IXboxAchievementApiClient
    {
        public XboxAchievementApiClient(HttpClient clientFactory, ILogger<XboxAchievementApiClient> logger) : base(clientFactory, logger)
        {
        }
    }
}