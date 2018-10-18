using mfgrupoCRM.Core.Domain;
using mfgrupoCRM.Data.Abstractions.Interfaces;
using mfgrupoCRM.Data.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mfgrupoCRM.Data.EntityFramework.Repositories
{
   public class CustomerRepository:ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public ApplicationDbContext Context { get; }

        public async Task<Customer> Delete(int id)
        {
            var customer = await Context.Customers
            .SingleOrDefaultAsync(o => o.Id == id);

            if (customer != null)
            {
                Context.Customers.Remove(customer);
                await Context.SaveChangesAsync();
            }

            return customer?.ToDomain();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public Task<bool> Exists(int id)
        {
            return Context.Customers.AnyAsync(e => e.Id == id);
        }

        public async Task<Customer> GetCustomerById(int customerId)
        {
            var customer = await Context.Customers.AsNoTracking().FirstOrDefaultAsync(a => a.Id == customerId);
            return customer?.ToDomain();
        }
        public async Task Create (Customer customer)
        {
            var efCustomer = CustomerDAO.FromDomain(customer);
            Context.Customers.Add(efCustomer);
            try
            {
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await Exists(customer.Id))
                {
                    throw;// new ArticleNotFoundException();
                }
                else
                {
                    throw;
                }
            }
        }
        public async Task Update(Customer customer)
        {
            var efCustomer= CustomerDAO.FromDomain(customer);

            Context.Attach(efCustomer).State = EntityState.Modified;
            try
            {
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await Exists(customer.Id))
                {
                    throw;// new ArticleNotFoundException();
                }
                else
                {
                    throw;
                }
            }
        }

        public (IEnumerable<Customer> customers, int totalFound) GetCustomersForSearchQuery(string filteredQuery, int offset, int resultsPerPage)
        {
         
                // WARNING:  This may need to be further refactored to allow for database optimized search queries

                var customers = Context.Customers
                    .AsNoTracking()
                    .Where(a =>
                        a.Fullname.ToUpper().Contains(filteredQuery.ToUpper())
                        || a.Fullname.ToUpper().Contains(filteredQuery.ToUpper())
                    ).Select(a => a.ToDomain());
                var customersCount = customers.Count();
                var list = customers.Skip(offset).Take(resultsPerPage).OrderByDescending(a => a.Id).ToList();

                return (list, customersCount);
            
        }
    }
}
