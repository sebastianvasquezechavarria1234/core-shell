using Microsoft.Extensions.Logging;

namespace AppConsola.Services;

internal sealed class MainService
{
    private readonly ILogger<MainService> _logger;

    public MainService(ILogger<MainService> logger)
    {
        _logger = logger;
    }

    public async Task RunAsync(string[] args)
    {
        _logger.LogInformation("Application started with {ArgCount} argument(s)", args.Length);

        Console.WriteLine("Hello, World!");
        Console.WriteLine($"Today's date is: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

        foreach (var arg in args)
        {
            _logger.LogInformation("Argument: {Arg}", arg);
        }

        await Task.CompletedTask;
    }
}
