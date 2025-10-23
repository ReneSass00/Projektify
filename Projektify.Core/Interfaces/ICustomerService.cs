
using Projektify.Core.Entities;

namespace Projektify.Core.Interfaces;

public interface ICustomerService
{
    Task<List<Customer>> GetAllCustomersAsync();
    Task CreateCustomerAsync(Customer customer);
}