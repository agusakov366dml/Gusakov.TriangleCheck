namespace Gusakov.TriangleCheck.Commands;

public class CheckTriangleCommand
{
    public double FirstSide;
    public double SecondSide;
    public double ThirdSide;

    public CheckTriangleCommand(double firstSide, double secondSide, double thirdSide) 
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }
}
