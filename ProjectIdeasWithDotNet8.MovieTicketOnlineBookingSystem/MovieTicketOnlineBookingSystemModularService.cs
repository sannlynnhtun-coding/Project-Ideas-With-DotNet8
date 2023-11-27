using Microsoft.Extensions.DependencyInjection;
using ProjectIdeasWithDotNet8.MovieTicketOnlineBookingSystem.Services;

namespace ProjectIdeasWithDotNet8.MovieTicketOnlineBookingSystem
{
    public static class MovieTicketOnlineBookingSystemModularService
    {
        public static IServiceCollection AddMovieTicketOnlineBookingSystemModularService(this IServiceCollection services, string jsonString)
        {
            services.AddScoped(n => new DataService(jsonString));
            return services;
        }
    }
}
