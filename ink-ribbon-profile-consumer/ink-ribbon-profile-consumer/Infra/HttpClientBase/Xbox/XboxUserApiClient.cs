using ink_ribbon_profile_consumer.Application.Services;
using ink_ribbon_profile_consumer.Domain.Dto.Xbox;
using ink_ribbon_profile_consumer.Domain.Interfaces.ApiClientService.Xbox;

namespace ink_ribbon_profile_consumer.Infra.HttpClientBase.Xbox
{
    public class XboxUserApiClient : ServiceClientBase<XboxUserDto, XboxUserApiClient>, IXboxUserApiClient
    {
        public XboxUserApiClient(HttpClient clientFactory, ILogger<XboxUserApiClient> logger) : base(clientFactory, logger)
        {
        }
    }
}