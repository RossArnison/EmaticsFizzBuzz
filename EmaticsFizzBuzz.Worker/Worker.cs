namespace EmaticsFizzBuzz.Worker;

public class Worker : BackgroundService
{
    private readonly IHostApplicationLifetime _hostLifetime;

    public Worker(IHostApplicationLifetime hostLifetime)
    {
        _hostLifetime = hostLifetime;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // TODO: Add Fizz Buzz Implementation
        
        _hostLifetime.StopApplication();
    }
}
