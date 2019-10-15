using AutoMapper;
using mfgrupoCRM.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mfgrupoCRM.Configuration.Startup
{
    public static class ConfigureAutomapperServices
    {

        public static IMapper ConfigureAutomapper(this IServiceCollection services)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CustomerProfile>();
            });

            config.AssertConfigurationIsValid();
            var mapper = config.CreateMapper();

            services?.AddSingleton(mapper);

            return mapper;

        }
    }
}
