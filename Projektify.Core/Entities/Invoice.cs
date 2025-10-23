using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projektify.Core.Entities;

public class Invoice
{
    public Guid Id { get; set; }
    public string InvoiceNumber { get; set; } = string.Empty; 
    public Guid ProjectId { get; set; }
    public Project Project { get; set; } = null!;

    public DateTime InvoiceDate { get; set; }
    public DateTime DueDate { get; set; }
    public InvoiceStatus Status { get; set; } = InvoiceStatus.Draft;

    public decimal SubTotal { get; set; } // Nettobetrag
    public decimal TaxAmount { get; set; } // Steuerbetrag
    public decimal Total { get; set; } // Bruttobetrag
    public ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
}

public enum InvoiceStatus { Draft, Sent, Paid, Canceled }