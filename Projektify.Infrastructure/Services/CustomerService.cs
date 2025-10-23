
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

    public async Task<List<Customer>> GetAllCustomersAsync()
    {
        return await _context.Customers
            .Where(c => !c.IsArchived) 
            .ToListAsync();
    }

    public async Task CreateCustomerAsync(Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
    }
}