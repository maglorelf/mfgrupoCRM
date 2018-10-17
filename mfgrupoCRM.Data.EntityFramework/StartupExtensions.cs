using System;
using mfgrupoCRM.Data.Abstractions.Interfaces;
using mfgrupoCRM.Data.EntityFramework.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace mfgrupoCRM.Data.EntityFramework
{
    public static class StartupExtensions
    {
      
		public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            //services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseSqlServer(
            //    config.GetConnectionString("DefaultConnection")));
           
           Action<DbContextOptionsBuilder> optionsBuilder;
            optionsBuilder = options => options.UseSqlServer(connectionString);


            services.AddDbContextPool<ApplicationDbContext>(options =>
            {
                optionsBuilder(options);
                options.EnableSensitiveDataLogging();
            });
            services.AddDefaultIdentity<IdentityUser>()
                           .AddEntityFrameworkStores<ApplicationDbContext>();
            //// db repos
          services.AddTransient<ICustomerRepository, CustomerRepository>();
          
            return services;

        }

        public static IServiceScope SeedData(this IServiceScope serviceScope)
        {

            //var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

            //ApplicationDbContext.SeedData(context);

            return serviceScope;

        }
    }
}
