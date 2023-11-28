using Gusakov.TriangleCheck.Enums;
using Gusakov.TriangleCheck.Exceptions;

namespace Gusakov.TriangleCheck.Services;

public class CheckerTriangleService : ICheckerTriangleService
{
    public TriangleType CheckTriangleType(
        double firstSide,
        double secondSide,
        double thirdSide)
    {
        CheckTriangleSidesForZerro(firstSide, secondSide, thirdSide);

        var SumOfAquaresOfSides = new List<double>()
        {
            Math.Pow(firstSide, 2),
            Math.Pow(secondSide, 2),
            Math.Pow(thirdSide, 2)
        };

        SumOfAquaresOfSides.Sort();

        if (IsAcuteTriangle(SumOfAquaresOfSides))
            return TriangleType.AcuteTriangle;

        if (IsObtuseTriangle(SumOfAquaresOfSides))
            return TriangleType.AcuteTriangle;

        if (IsRightTriangle(SumOfAquaresOfSides))
            return TriangleType.AcuteTriangle;

        return TriangleType.None;
    }

    private bool IsAcuteTriangle(List<double> sumOfAquaresOfSides) => 
        sumOfAquaresOfSides[0] + sumOfAquaresOfSides[1] > sumOfAquaresOfSides[2] 
        ? true 
        : false;

    private bool IsObtuseTriangle(List<double> sumOfAquaresOfSides) =>
        sumOfAquaresOfSides[0] + sumOfAquaresOfSides[1] < sumOfAquaresOfSides[2] 
        ? true
        : false;

    private bool IsRightTriangle(List<double> sumOfAquaresOfSides) =>
        sumOfAquaresOfSides[0] + sumOfAquaresOfSides[1] == sumOfAquaresOfSides[2]
    ? true
    : false;

    private void CheckTriangleSidesForZerro(
        double firstSide,
        double secondSide,
        double thirdSide)
    {
        if (firstSide == 0 
            || secondSide == 0 
            || thirdSide == 0)
            throw new ValueOfTheSidesOfTheTriangleIsZero("Стороны треугольника не должны иметь значение равное 0");
    }
}
