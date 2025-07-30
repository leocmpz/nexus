using Nexus.Application.Common;
using Nexus.Domain.Entities;
using Nexus.Domain.Repositories;

namespace Nexus.Application.Owners.Commands.CreateInstitution;

public class CreateInstitutionCommandHandler : ICommandHandler<CreateInstitutionCommand, Guid>
{
    private readonly IOwnerRepository _ownerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateInstitutionCommandHandler(IOwnerRepository ownerRepository, IUnitOfWork unitOfWork)
    {
        _ownerRepository = ownerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Guid> Handle(CreateInstitutionCommand command, CancellationToken cancellationToken)
    {
        var institution = new Institution(command.Name, command.Mnemonic, command.SinacorId, command.Document);

        await _ownerRepository.AddAsync(institution, cancellationToken);

        await _unitOfWork.CommitAsync(cancellationToken);

        return institution.Id;
    }
}
