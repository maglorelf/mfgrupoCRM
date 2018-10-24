using mfgrupoCRM.Data.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace mfgrupoCRM.Configuration.Startup
{
    public static partial class ConfigurationExtensions
    {
        public static IServiceCollection ConfigureDatabase(this IServiceCollection services, IConfiguration config)
        {
            services.AddRepositories(config);
            return services;
        }

        public static IApplicationBuilder ConfigureDatabase(this IApplicationBuilder app)
        {


            var scope = app.ApplicationServices.CreateScope();

            //var identityContext = scope.SeedData()
            //    .ServiceProvider.GetService<CoreWikiIdentityContext>();
            //CoreWikiIdentityContext.SeedData(identityContext);

            return app;
        }
    }
}
