using Microsoft.Extensions.DependencyInjection;
using ProjectIdeasWithDotNet8.Zodiac.Services;

namespace ProjectIdeasWithDotNet8.Zodiac;

public static class ZodiacModularService
{
    public static IServiceCollection AddZodiacService(this IServiceCollection services)
    {
        services.AddScoped<DataService>();
        return services;
    }
}