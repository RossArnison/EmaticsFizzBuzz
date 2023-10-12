using EmaticsFizzBuzz.Worker;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(ConfigureServices)
    .Build();

void ConfigureServices(HostBuilderContext context, IServiceCollection services)
{
    // TOD0: Setup service dependency injection
    
    services.AddHostedService<Worker>();
}

host.Run();