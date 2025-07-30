using Nexus.Domain.Abstractions;

namespace Nexus.Domain.Entities;

public sealed class Position : Entity
{
    public Guid OwnerId { get; set; }
    public Guid BondId { get; set; }
    public Guid OrderId { get; set; }
    public DateOnly Date { get; set; }
    public decimal Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal GrossValue { get; set; }
    public decimal IrValue { get; set; }
    public decimal IofValue { get; set; }
    public decimal NetValue { get; set; }
}