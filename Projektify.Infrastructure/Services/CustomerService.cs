using Microsoft.EntityFrameworkCore;
using Projektify.Core.Entities;
using Projektify.Core.Interfaces;
namespace Projektify.Infrastructure.Services;
public class CustomerService : ICustomerService
{
    private readonly ApplicationDbContext _context;
    public CustomerService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<Customer>> GetAllCustomersAsync(bool includeArchived = false)
    {
        var query = _context.Customers.AsQueryable();
        if (!includeArchived)
        {
            query = query.Where(c => !c.IsArchived);
        }
        return await query.OrderBy(c => c.CompanyName).ToListAsync();
    }
    public async Task<Customer?> GetCustomerByIdAsync(Guid id)
    {
        return await _context.Customers.FindAsync(id);
    }
    public async Task CreateCustomerAsync(Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateCustomerAsync(Customer customer)
    {
        _context.Entry(customer).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
    public async Task ArchiveCustomerAsync(Guid id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer != null)
        {
            customer.IsArchived = true;  // Soft-Archive
            await _context.SaveChangesAsync();
        }
    }
}