using Nexus.Domain.Enums;

namespace Nexus.Domain.Entities;

public sealed class OrderDetail
{
    public OrderDetail(Guid orderId, OrderMarket market, OrderStatus status, decimal? rate, decimal? executedRate)
    {
        OrderId = orderId;
        Market = market;
        Status = status;
        Rate = rate;
        ExecutedRate = executedRate;
    }

    public Guid OrderId { get; set; }
    public OrderMarket Market { get; set; }
    public OrderStatus Status { get; set; }
    public decimal? Rate { get; set; }
    public decimal? ExecutedRate { get; set; }
}
