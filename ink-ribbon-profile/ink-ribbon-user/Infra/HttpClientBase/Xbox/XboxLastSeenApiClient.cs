using ink_ribbon_profile.Application.Services;
using ink_ribbon_profile.Domain.Dto.Xbox;
using ink_ribbon_profile.Domain.Interfaces.ApiClientService.Xbox;

namespace ink_ribbon_profile.Infra.HttpClientBase.Xbox
{
    public class XboxLastSeenApiClient : ServiceClientBase<XboxLastSeenDto, XboxLastSeenApiClient>, IXboxLastSeenApiClient
    {
        public XboxLastSeenApiClient(HttpClient clientFactory, ILogger<XboxLastSeenApiClient> logger) : base(clientFactory, logger)
        {
        }
    }
}