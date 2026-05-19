using AppConsola.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<MainService>();

var host = builder.Build();

var mainService = host.Services.GetRequiredService<MainService>();
await mainService.RunAsync(args);
