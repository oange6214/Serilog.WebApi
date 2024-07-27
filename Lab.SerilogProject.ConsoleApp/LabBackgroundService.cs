using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Lab.SerilogProject.ConsoleApp;

public class LabBackgroundService : BackgroundService
{
    private readonly ILogger<LabBackgroundService> _logger;

    public LabBackgroundService(ILogger<LabBackgroundService> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation(
            new EventId(2000, "Trace"),
            "Start {ClassName}.{MethodName}...",
            nameof(LabBackgroundService),
            nameof(ExecuteAsync)
            );

        var sensorInput = new { Latitude = 25, Longitude = 134 };
        _logger.LogInformation("Processing {@SensorInput}", sensorInput);
    }
}