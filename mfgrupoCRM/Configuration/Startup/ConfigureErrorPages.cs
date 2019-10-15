using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace mfgrupoCRM.Configuration.Startup
{
    public static partial class ConfigurationExtensions
    {
        public static IApplicationBuilder ConfigureErrorPages(this IApplicationBuilder app,          IWebHostEnvironment env)
       {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            return app;
        }
    }
}
