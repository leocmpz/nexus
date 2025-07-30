namespace Nexus.Application.Common;

public interface ICommandHandler<in TRequest, TResponse> where TRequest : ICommand<TResponse>
{
    Task<TResponse> Handle(TRequest command, CancellationToken cancellationToken);
}