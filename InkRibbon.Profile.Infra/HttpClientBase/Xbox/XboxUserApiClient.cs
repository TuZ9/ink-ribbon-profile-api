using ink_ribbon_profile_api.Application.Services;
using ink_ribbon_profile_api.Domain.Dto.Xbox;
using ink_ribbon_profile_api.Domain.Interfaces.ApiClientService.Xbox;
using Microsoft.Extensions.Logging;

namespace ink_ribbon_profile_api.Infra.HttpClientBase.Xbox
{
    public class XboxUserApiClient : ServiceClientBase<XboxUserDto, XboxUserApiClient>, IXboxUserApiClient
    {
        public XboxUserApiClient(HttpClient clientFactory, ILogger<XboxUserApiClient> logger) : base(clientFactory, logger)
        {
        }
    }
}