using Nexus.Domain.Entities;

namespace Nexus.Domain.Repositories;

public interface IOwnerRepository
{
    Task AddAsync(Customer customer, CancellationToken cancellationToken);
    Task AddAsync(Institution institution, CancellationToken cancellationToken);
}
