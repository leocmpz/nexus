using Nexus.Application.Common;
using Nexus.Domain.Entities;
using Nexus.Domain.Repositories;

namespace Nexus.Application.Owners.Commands.CreateCustomer;

public class CreateCustomerCommandHandler : ICommandHandler<CreateCustomerCommand, Guid>
{
    private readonly IOwnerRepository _ownerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateCustomerCommandHandler(IOwnerRepository ownerRepository, IUnitOfWork unitOfWork)
    {
        _ownerRepository = ownerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Guid> Handle(CreateCustomerCommand command, CancellationToken cancellationToken)
    {
        var customer = new Customer(command.ApiId, command.SinacorId, command.Document);

        await _ownerRepository.AddAsync(customer, cancellationToken);

        await _unitOfWork.CommitAsync(cancellationToken);

        return customer.Id;
    }
}
