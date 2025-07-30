using FluentValidation;

namespace Nexus.Application.Owners.Commands.CreateCustomer;

public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
        RuleFor(x => x.ApiId)
            .NotEmpty()
            .WithMessage("ApiId is required.");

        RuleFor(x => x.SinacorId)
            .NotEmpty()
            .WithMessage("SinacorId is required.");

        RuleFor(x => x.Document)
            .NotEmpty()
            .WithMessage("Document is required.");
    }
}
