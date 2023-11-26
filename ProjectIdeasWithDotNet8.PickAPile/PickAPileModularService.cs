using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectIdeasWithDotNet8.PickAPile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.PickAPile
{
    public static class PickAPileModularService
    {
        public static IServiceCollection AddPickAPileService(this IServiceCollection services)
        {
            services.AddScoped<DataService>();
            return services;
        }
    }
}
