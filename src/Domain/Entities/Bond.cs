using Nexus.Domain.Abstractions;

namespace Nexus.Domain.Entities;

public sealed class Bond : Entity
{
    public Bond(
        string code,
        DateTime maturityDate,
        DateTime issueDate,
        Guid typeId,
        Guid issuerId,
        decimal faceValue,
        decimal? fixedRate,
        decimal? floatedRate,
        Guid? indexId) : base()
    {
        Code = code;
        MaturityDate = maturityDate;
        IssueDate = issueDate;
        TypeId = typeId;
        IssuerId = issuerId;
        FaceValue = faceValue;
        FixedRate = fixedRate;
        FloatedRate = floatedRate;
        IndexId = indexId;
    }

    public string Code { get; set; }
    public DateTime MaturityDate { get; set; }
    public DateTime IssueDate { get; set; }
    public Guid TypeId { get; set; }
    public Guid IssuerId { get; set; }
    public decimal FaceValue { get; set; }
    public decimal? FixedRate { get; set; }
    public decimal? FloatedRate { get; set; }
    public Guid? IndexId { get; set; }
}
