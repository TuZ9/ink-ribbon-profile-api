namespace ink_ribbon_profile_api.Infra.Extensions.Logger
{
    public sealed class ColorConsoleLoggerConfiguration
    {
        public int EventId { get; set; }

        public Dictionary<LogLevel, ConsoleColor> LogLevelToColorMap { get; set; } = new()
        {
            [LogLevel.Information] = ConsoleColor.White,
            [LogLevel.Error] = ConsoleColor.Red,
        };
    }
}
