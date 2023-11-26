using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIdeasWithDotNet8.MyanmarProverbs.Services;

namespace ProjectIdeasWithDotNet8.MyanmarProverbs;

public static class MyanmarProverbsModularService
{
    public static IServiceCollection AddMyanmarProverbsService(this IServiceCollection services)
    {
        services.AddScoped<DataService>();
        return services;
    }
}
