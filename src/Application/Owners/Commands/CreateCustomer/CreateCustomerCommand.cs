
using Nexus.Application.Common;

namespace Nexus.Application.Owners.Commands.CreateCustomer;

public sealed record CreateCustomerCommand(string ApiId, string SinacorId, string Document) : ICommand<Guid>;
