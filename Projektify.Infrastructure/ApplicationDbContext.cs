
using Microsoft.EntityFrameworkCore;
using Projektify.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Projektify.Infrastructure;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<TimeEntry> TimeEntries { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceItem> InvoiceItems { get; set; }
    public DbSet<UserSettings> UserSettings { get; set; }
}