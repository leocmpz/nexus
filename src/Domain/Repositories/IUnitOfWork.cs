namespace Nexus.Domain.Repositories;

public interface IUnitOfWork
{
    Task CommitAsync(CancellationToken cancellationToken);
}
