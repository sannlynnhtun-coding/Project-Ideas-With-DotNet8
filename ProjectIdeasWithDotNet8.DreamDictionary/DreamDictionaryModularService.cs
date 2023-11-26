using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectIdeasWithDotNet8.DreamDictionary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.DreamDictionary
{
    public static class DreamDictionaryModularService
    {
        public static IServiceCollection AddDreamDictionaryService(this IServiceCollection services)
        {
            services.AddScoped<DataService>();
            return services;
        }
    }
}
