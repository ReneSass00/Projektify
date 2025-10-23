using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektify.Core.Entities;

public class UserSettings
{
    public Guid Id { get; set; } 
    public string CompanyName { get; set; } = string.Empty;
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? TaxNumber { get; set; }
    public string? BankDetails { get; set; }
    public decimal DefaultHourlyRate { get; set; }
    public decimal DefaultTaxRate { get; set; }
}