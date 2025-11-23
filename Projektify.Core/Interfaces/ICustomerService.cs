using Projektify.Core.Entities;
namespace Projektify.Core.Interfaces;
public interface ICustomerService
{
    Task<List<Customer>> GetAllCustomersAsync(bool includeArchived = false);
    Task<Customer?> GetCustomerByIdAsync(Guid id);
    Task CreateCustomerAsync(Customer customer);
    Task UpdateCustomerAsync(Customer customer);
    Task ArchiveCustomerAsync(Guid id);
}