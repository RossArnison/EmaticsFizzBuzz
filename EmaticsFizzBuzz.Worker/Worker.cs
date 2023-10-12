using EmaticsFizzBuzz.Worker.Model;
using EmaticsFizzBuzz.Worker.Service.Interface;
using Microsoft.Extensions.Options;

namespace EmaticsFizzBuzz.Worker;

public class Worker : BackgroundService
{
    private readonly IHostApplicationLifetime _hostLifetime;
    private readonly IFizzBuzzService _service;
    private readonly FizzBuzzSettings _settings;
    
    public Worker(IHostApplicationLifetime hostLifetime, IFizzBuzzService service, IOptions<FizzBuzzSettings> settings)
    {
        _hostLifetime = hostLifetime;
        _service = service;
        _settings = settings.Value;
    }

    protected override async Task ExecuteAsync(CancellationToken token)
    {
        var sequence = await _service.CreateSequenceAsync(_settings.FizzBuzzStart, _settings.FizzBuzzEnd, token);
        
        foreach (var sequenceItem in sequence)
        {
            Console.WriteLine(sequenceItem);
        }
        
        _hostLifetime.StopApplication();
    }
}
