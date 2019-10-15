
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Blazorise;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;
namespace mfgrupoCRM.Configuration.Startup
{
    public static partial class ConfigurationExtensions
    {
        public static IServiceCollection ConfigureBlazor(this IServiceCollection services, IConfiguration config)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddBlazorise(options =>
             {
                 options.ChangeTextOnKeyPress = true;
             }) // from v0.6.0-preview4
                .AddBulmaProviders()
                .AddFontAwesomeIcons();
            return services;
        }

        public static IApplicationBuilder ConfigureBlazor(this IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.ApplicationServices
                    .UseBulmaProviders()
                    .UseFontAwesomeIcons();

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
            return app;
        }
    }
}
