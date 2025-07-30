using Nexus.Application.Common;
using Nexus.Domain.Entities;
using Nexus.Domain.Repositories;

namespace Nexus.Application.Bonds.Commands.CreateBond;

public class CreateBondCommandHandler : ICommandHandler<CreateBondCommand, Guid>
{
    private readonly IBondRepository _bondRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateBondCommandHandler(IBondRepository bondRepository, IUnitOfWork unitOfWork)
    {
        _bondRepository = bondRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Guid> Handle(CreateBondCommand command, CancellationToken cancellationToken)
    {
        var bond = new Bond(
            command.Code, 
            command.MaturityDate, 
            command.IssueDate, 
            command.TypeId, 
            command.IssuerId, 
            command.FaceValue, 
            command.FixedRate, 
            command.FloatedRate, 
            command.IndexId);

        await _bondRepository.AddAsync(bond, cancellationToken);

        await _unitOfWork.CommitAsync(cancellationToken);

        return bond.Id;
    }
}
