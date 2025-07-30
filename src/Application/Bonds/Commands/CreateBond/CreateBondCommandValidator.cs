using FluentValidation;

namespace Nexus.Application.Bonds.Commands.CreateBond;

public class CreateBondCommandValidator : AbstractValidator<CreateBondCommand>
{
    public CreateBondCommandValidator()
    {
    }
}
