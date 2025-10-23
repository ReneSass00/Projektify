using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektify.Core.Entities;

public class Customer
{
    public Guid Id { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string? ContactName { get; set; }
    public string Email { get; set; } = string.Empty;
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? TaxNumber { get; set; }
    public bool IsArchived { get; set; } = false;

    // Beziehung: Ein Kunde hat viele Projekte
    public ICollection<Project> Projects { get; set; } = new List<Project>();
}