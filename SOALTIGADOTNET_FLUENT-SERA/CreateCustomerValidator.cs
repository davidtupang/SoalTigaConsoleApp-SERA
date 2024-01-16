using FluentValidation;
using SOALTIGADOTNET_MEDIATOR_SERA;

namespace SOALTIGADOTNET_FLUENT_SERA;

public class CreateCustomerValidator : AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerValidator()
    {
        RuleFor(x => x.CustomerCode).NotEmpty();
        RuleFor(x => x.CustomerName).NotEmpty();
    }
}
