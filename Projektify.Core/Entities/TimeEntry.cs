using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projektify.Core.Entities;

public class TimeEntry
{
    public Guid Id { get; set; }
    public Guid ProjectId { get; set; }
    public Project Project { get; set; } = null!;

    public DateTime Date { get; set; }
    public decimal Hours { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsBilled { get; set; } = false;
    public Guid? InvoiceItemId { get; set; }
    public InvoiceItem? InvoiceItem { get; set; }
}