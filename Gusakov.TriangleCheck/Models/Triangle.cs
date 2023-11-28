using Gusakov.TriangleCheck.Enums;
using Gusakov.TriangleCheck.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Gusakov.TriangleCheck.Models;

public class Triangle
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;
    private readonly ICheckerTriangleService _checkerTriangleService;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
        _checkerTriangleService = DependencyContainer
            .GetContainer()
            .GetRequiredService<ICheckerTriangleService>();
    }

    public TriangleType GetTriangleType() =>
        _checkerTriangleService.CheckTriangleType(_firstSide, _secondSide, _thirdSide);
}
