using mfgrupoCRM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mfgrupoCRM.Data.Abstractions.Interfaces
{
    public interface ICustomerRepository : IDisposable
    {
        Task<Customer> GetCustomerById(int customerId);
        Task<bool> Exists(int id);
        Task Update(Customer customer);
        Task<Customer> Delete(int id);
        Task Create(Customer customer);
        (IEnumerable<Customer> customers, int totalFound) GetCustomersForSearchQuery(string filteredQuery, int offset, int resultsPerPage);
    }
}



