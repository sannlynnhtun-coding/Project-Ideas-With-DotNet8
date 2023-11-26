using Microsoft.Extensions.DependencyInjection;
using ProjectIdeasWithDotNet8.BaganMap.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.BaganMap
{
    public static class BaganMapModularService
    {
        public static IServiceCollection AddBaganMapModularService(this IServiceCollection services)
        {
            services.AddScoped<DataService>();
            return services;
        }
    }
}
