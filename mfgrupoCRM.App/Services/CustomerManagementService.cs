using AutoMapper;
using mfgrupoCRM.App.Abstractions.Interfaces;
using mfgrupoCRM.App.Dto;
using mfgrupoCRM.Core.Domain;
using mfgrupoCRM.Data.Abstractions.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mfgrupoCRM.App.Services
{
    public class CustomerManagementService : ICustomerManagementService
    {
        protected ICustomerRepository repository;
        protected IMapper mapper;
        public CustomerManagementService(ICustomerRepository customerRepository,IMapper mapper)
        {
            repository = customerRepository;
            mapper = mapper;
        }
        public async Task<Customer> CreateCustomer(Customer customer)
        {
            await repository.Create(customer);
            // await _mediator.Publish(new ArticleCreatedNotification(createdArticle));
            return customer;
        }

        public async Task Update(int id, string name)
        {

            Customer existingCustomer = await repository.GetCustomerById(id);
            if (existingCustomer != null && existingCustomer.Id != id)
            {
                //  throw new InvalidTopicException("The topic conflicts with an existing article.");
            }

            existingCustomer = await repository.GetCustomerById(id);

            //if (!Changed(existingCustomer.Topic, topic) && !Changed(existingCustomer.Content, content))
            //{
            //    throw new NoContentChangedException();
            //}


            existingCustomer.Fullname = name;
            await repository.Update(existingCustomer);
            //if (Changed(oldSlug, existingCustomer.Slug))
            //{
            //    await _slugHistoryRepository.AddToHistory(oldSlug, existingCustomer);
            //}
            //await _mediator.Publish(new ArticleEditedNotification(existingCustomer));
        }

        public async Task<Customer> Delete(int id)
        {
            Customer customer = await repository.GetCustomerById(id);

            Customer deletedCustomer = await repository.Delete(id);
            //  await _mediator.Publish(new ArticleDeletedNotification(deletedArticle));
            return customer;
        }

        public async Task<CustomerManageDto> GetCustomerById(int id)
        {
            return mapper.Map<CustomerManageDto>(await repository.GetCustomerById(id));
        }

       
        public async Task<SearchResultDto<CustomerManageDto>> GetCustomers(string query, int pageNumber, int resultsPerPage)
        {
            var filteredQuery = query.Trim();
            var offset = (pageNumber - 1) * resultsPerPage;

            var (customers, totalFound) = repository.GetCustomersForSearchQuery(filteredQuery, offset, resultsPerPage);

            var result = new SearchResult<Customer>
            {
                Query = filteredQuery,
                Results = customers.ToList(),
                CurrentPage = pageNumber,
                ResultsPerPage = resultsPerPage,
                TotalResults = totalFound
            };

            return mapper.Map<SearchResultDto<CustomerManageDto>>(result);
        }
    }
}
