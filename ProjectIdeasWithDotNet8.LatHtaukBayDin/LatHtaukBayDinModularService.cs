using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MinTheinKha.LatHtaukBayDin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.LatHtaukBayDin
{
    public static class LatHtaukBayDinModularService
    {
        public static IServiceCollection AddLatHtaukBayDinModularService(this IServiceCollection services)
        {
            services.AddScoped<DataService>();
            return services;
        }
    }
}
