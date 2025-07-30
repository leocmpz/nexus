using Nexus.Domain.Entities;

namespace Nexus.Domain.Repositories;

public interface IBondRepository
{
    Task AddAsync(Bond bond, CancellationToken cancellationToken);
}
