using mfgrupoCRM.Data.EntityFramework.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace mfgrupoCRM.Data.EntityFramework
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CustomerDAO> Customers { get; set; }
        public override Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(cancellationToken);
        }


        public static void SeedData(ApplicationDbContext context)
        {

            context.Database.Migrate();

        }
    }
}
