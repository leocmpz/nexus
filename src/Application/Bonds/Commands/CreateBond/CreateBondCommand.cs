

using Nexus.Application.Common;

namespace Nexus.Application.Bonds.Commands.CreateBond;

public record CreateBondCommand(
    string Code,
    DateTime MaturityDate,
    DateTime IssueDate,
    Guid TypeId,
    Guid IssuerId,
    decimal FaceValue,
    decimal? FixedRate,
    decimal? FloatedRate,
    Guid? IndexId) : ICommand<Guid>;
