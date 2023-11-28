namespace Gusakov.TriangleCheck.Exceptions;

public class ValueOfTheSidesOfTheTriangleIsZero : Exception
{
    public ValueOfTheSidesOfTheTriangleIsZero(string message)
        : base(message) { }
}
