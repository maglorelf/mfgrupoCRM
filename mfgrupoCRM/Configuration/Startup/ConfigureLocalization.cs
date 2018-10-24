
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace mfgrupoCRM.Configuration.Startup
{
    public static partial class ConfigurationExtensions
    {
        public static IServiceCollection ConfigureLocalization(this IServiceCollection services, IConfiguration config)
        {
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc()               
                 .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                   .AddDataAnnotationsLocalization();
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en-GB"),
                    new CultureInfo("es-ES"),
                };

                // State what the default culture for your application is. This will be used if no specific culture
                // can be determined for a given request.
                options.DefaultRequestCulture = new RequestCulture(culture: "en-GB", uiCulture: "en-GB");

                // You must explicitly state which cultures your application supports.
                // These are the cultures the app supports for formatting numbers, dates, etc.
                options.SupportedCultures = supportedCultures;

                // These are the cultures the app supports for UI strings, i.e. we have localized resources for.
                options.SupportedUICultures = supportedCultures;
            });
            return services;
        }

        public static IApplicationBuilder ConfigureLocalization(this IApplicationBuilder app)
        {
            IOptions<RequestLocalizationOptions> options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(options.Value);
            return app;
        }
    }
}
