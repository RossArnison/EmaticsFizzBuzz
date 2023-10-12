using EmaticsFizzBuzz.Worker;
using EmaticsFizzBuzz.Worker.Service;
using EmaticsFizzBuzz.Worker.Service.Interface;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(ConfigureServices)
    .Build();

void ConfigureServices(HostBuilderContext context, IServiceCollection services)
{
    services.AddTransient<IFizzBuzzService, FizzBuzzService>();
    
    services.AddHostedService<Worker>();
}

host.Run();