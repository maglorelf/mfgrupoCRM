using mfgrupoCRM.App.Abstractions.Interfaces;
using mfgrupoCRM.App.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mfgrupoCRM.Configuration.Startup
{
    public static class ConfigureApplicationLayer
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<ICustomerManagementService, CustomerManagementService>();
            return services;
        }
    }
}
