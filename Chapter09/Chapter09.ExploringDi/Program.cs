using Chapter09.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

// Inject dependencies (DI)
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<IWeatherForecastService, WeatherForecastService>();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddLogging(builder =>
    {
        builder.ClearProviders();
        builder.AddConsole();
        builder.AddDebug();
    });
}

// Add middleware
var app = builder.Build();

app.MapControllers();

app.Run();
