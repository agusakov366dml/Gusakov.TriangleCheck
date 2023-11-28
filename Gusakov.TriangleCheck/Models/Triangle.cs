using FluentValidation;
using Gusakov.TriangleCheck.Commands;
using Gusakov.TriangleCheck.Enums;
using Gusakov.TriangleCheck.Exceptions;
using Gusakov.TriangleCheck.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Gusakov.TriangleCheck.Models;

public class Triangle
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;
    private readonly ICheckerTriangleService _checkerTriangleService;
    private readonly IValidator<CheckTriangleCommand> _validator;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;

        _checkerTriangleService = DependencyContainer
            .GetContainer()
            .GetRequiredService<ICheckerTriangleService>();

        _validator = DependencyContainer
            .GetContainer()
            .GetRequiredService<IValidator<CheckTriangleCommand>>();
    }

    public TriangleType GetTriangleType()
    {
        var command = new CheckTriangleCommand(_firstSide, _secondSide, _thirdSide);
        var result = _validator.Validate(command);
        if (!result.IsValid)
        {
            throw new ValueOfTheSidesOfTheTriangleIsZero("Стороны треугольника не должны иметь значение равное 0");
        }
        return _checkerTriangleService.CheckTriangleType(_firstSide, _secondSide, _thirdSide);
    }
}
