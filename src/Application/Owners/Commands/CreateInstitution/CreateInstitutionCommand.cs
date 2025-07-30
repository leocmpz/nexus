using Nexus.Application.Common;

namespace Nexus.Application.Owners.Commands.CreateInstitution;

public sealed record CreateInstitutionCommand(
    string Name,
    string Mnemonic,
    string SinacorId, 
    string Document) : ICommand<Guid>;