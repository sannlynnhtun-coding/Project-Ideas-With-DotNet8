using Microsoft.Extensions.DependencyInjection;
using ProjectIdeasWithDotNet8.Birds.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.Birds
{
    public static class BirdsModularService
    {
        public static IServiceCollection AddBirdsService(this IServiceCollection services)
        {
            services.AddScoped<DataService>();
            return services;
        }
    }
}
