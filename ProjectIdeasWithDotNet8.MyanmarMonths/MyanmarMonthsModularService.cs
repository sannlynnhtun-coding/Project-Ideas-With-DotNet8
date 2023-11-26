using Microsoft.Extensions.DependencyInjection;
using ProjectIdeasWithDotNet8.MyanmarMonths.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.MyanmarMonths
{
    public static class MyanmarMonthsModularService
    {
        public static IServiceCollection AddMyanmarMonthsService(this IServiceCollection services)
        {
            services.AddScoped<DataService>();
            return services;
        }
    }
}
