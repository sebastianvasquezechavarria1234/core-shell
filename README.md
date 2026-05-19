# AppConsola

A modern .NET 9.0 console application template with dependency injection, structured logging, and configuration management.

## Features

- Built with .NET 9.0
- Dependency injection via `Microsoft.Extensions.Hosting`
- Structured logging with `ILogger<T>`
- Environment-aware configuration (`appsettings.json` + `appsettings.Development.json`)
- Async entry point (`async Task Main`)
- Clean project structure with separated service layer

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

## Getting Started

```bash
dotnet restore
dotnet run
```

To pass arguments:

```bash
dotnet run -- arg1 arg2 arg3
```

## Project Structure

```
AppConsola/
├── Services/
│   └── MainService.cs       # Application entry logic
├── appsettings.json          # Production configuration
├── appsettings.Development.json  # Development configuration
├── Program.cs                # Host bootstrap
├── AppConsola.csproj         # Project file
└── .gitignore                # Ignored files
```

## License

This project is for educational purposes.
