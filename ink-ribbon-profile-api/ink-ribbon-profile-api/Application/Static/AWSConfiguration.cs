namespace ink_ribbon_profile_api.Application.Static
{
    public class AWSConfiguration
    {
        public string? AWSRegion { get; set; }
        public string? SQSUri { get; set; }
        public string? SQSDLUri { get; set; }
        public string? SNSUri { get; set; }
        public string? TopicArn { get; set; }
        public string? SQSLakeUri { get; set; }
    }
}
