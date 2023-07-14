using Serilog;

namespace MyWrapper;
public sealed class Wrapper {
    private readonly ILogger _logger;
    public Wrapper() {
        _logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .CreateLogger();
    }
    public void Information(string message) => _logger.Information(message);
    public void Debug(string message) => _logger.Debug(message);
    public void Warning(string message) => _logger.Warning(message);
    public void Error(string message) => _logger.Error(message);
}