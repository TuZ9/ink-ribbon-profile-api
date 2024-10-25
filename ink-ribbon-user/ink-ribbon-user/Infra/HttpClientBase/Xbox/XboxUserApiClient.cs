using ink_ribbon_profile.Application.Services;
using ink_ribbon_profile.Domain.Dto.Xbox;
using ink_ribbon_profile.Domain.Interfaces.ApiClientService.Xbox;

namespace ink_ribbon_profile.Infra.HttpClientBase.Xbox
{
    public class XboxUserApiClient : ServiceClientBase<XboxUserDto, XboxUserApiClient>, IXboxUserApiClient
    {
        public XboxUserApiClient(HttpClient clientFactory, ILogger<XboxUserApiClient> logger) : base(clientFactory, logger)
        {
        }
    }
}