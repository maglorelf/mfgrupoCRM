using mfgrupoCRM.App.Dto;
using mfgrupoCRM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mfgrupoCRM.App.Abstractions.Interfaces
{
  public  interface ICustomerManagementService
    {
        Task<Customer> CreateCustomer(Customer customer);
        Task Update(int id, string fullname);
        Task<Customer> Delete(int id);
        Task<CustomerManageDto> GetCustomerById(int id);
        Task<SearchResultDto<CustomerManageDto>> GetCustomers(string query, int pageNumber, int resultsPerPage);


    }
}
