using Gusakov.TriangleCheck.Enums;

namespace Gusakov.TriangleCheck.Services;

public interface ICheckerTriangleService
{
    TriangleType CheckTriangleType(
        double firstSide,
        double secondSide,
        double thirdSide);
}
