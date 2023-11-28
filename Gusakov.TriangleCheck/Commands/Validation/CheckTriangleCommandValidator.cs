using FluentValidation;

namespace Gusakov.TriangleCheck.Commands.Validation;

public class CheckTriangleCommandValidator : AbstractValidator<CheckTriangleCommand> 
{
    public CheckTriangleCommandValidator()
    {
        RuleFor(x => x.FirstSide)
            .NotEqual(0);

        RuleFor(x => x.SecondSide)
            .NotEqual(0);

        RuleFor(x => x.ThirdSide)
            .NotEqual(0);
    }
}
