using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projektify.Core.Entities;

public class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public ProjectStatus Status { get; set; } = ProjectStatus.Active;
    public decimal? Budget { get; set; } 
    public DateTime? Deadline { get; set; } 
    public ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
    public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}

public enum ProjectStatus { Active, Completed, Archived }