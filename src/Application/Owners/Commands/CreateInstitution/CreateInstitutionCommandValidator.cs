using FluentValidation;

namespace Nexus.Application.Owners.Commands.CreateInstitution;

public class CreateInstitutionCommandValidator : AbstractValidator<CreateInstitutionCommand>
{
    public CreateInstitutionCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is required.");

        RuleFor(x => x.Mnemonic)
            .NotEmpty()
            .WithMessage("Mnemonic is required.");

        RuleFor(x => x.SinacorId)
            .NotEmpty()
            .WithMessage("SinacorId is required.");

        RuleFor(x => x.Document)
            .NotEmpty()
            .WithMessage("Document is required.");
    }
}
