using Nexus.Domain.Abstractions;
using Nexus.Domain.Enums;

namespace Nexus.Domain.Entities;

public sealed class Order : Entity
{
    public Order(
        Guid ownerId,
        Guid bondId,
        Guid typeId,
        DateTime operationDate,
        DateTime settlementDate,
        decimal quantity,
        decimal executedUnitPrice,
        decimal unitPrice,
        decimal irValue,
        decimal iofValue,
        OrderMarket market,
        decimal? rate, 
        decimal? executedRate) : base()
    {
        var grossValue = quantity * unitPrice;

        OwnerId = ownerId;
        BondId = bondId;
        TypeId = typeId;
        OperationDate = operationDate;
        SettlementDate = settlementDate;
        Quantity = quantity;
        ExecutedUnitPrice = executedUnitPrice;
        UnitPrice = unitPrice;
        GrossValue = grossValue;
        IrValue = irValue;
        IofValue = iofValue;
        NetValue = grossValue - irValue - iofValue;

        Detail = new OrderDetail(Id, market, OrderStatus.Draft, rate, executedRate);
    }

    public Guid OwnerId { get; private set; }
    public Guid BondId { get; set; }
    public Guid TypeId { get; set; }
    public DateTime OperationDate { get; set; }
    public DateTime SettlementDate { get; set; }
    public decimal Quantity { get; set; }
    public decimal ExecutedUnitPrice { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal GrossValue { get; set; }
    public decimal IrValue { get; set; }
    public decimal IofValue { get; set; }
    public decimal NetValue { get; set; }
    public OrderDetail Detail { get; set; }
}
