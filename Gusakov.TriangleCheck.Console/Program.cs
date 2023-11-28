using Gusakov.TriangleCheck.Enums;
using Gusakov.TriangleCheck.Models;

Console.WriteLine("Проверим Треугольник");

Console.WriteLine("Введите длинну первой стороны");

if(double.TryParse(Console.ReadLine(), out var firstNumber) 
    && double.TryParse(Console.ReadLine(), out var secondNumber) 
    && double.TryParse(Console.ReadLine(), out var thirdNumber)) 
{
    var triangleType = new Triangle(
        firstNumber,
        secondNumber,
        thirdNumber)
        .GetTriangleType();

    var message = triangleType switch
    {
        TriangleType.AcuteTriangle => "Острый угол",
        TriangleType.ObtuseTriangle => "Тупой Угол",
        TriangleType.RightTriangle => "Прямой Угол",
        _ => "Не удалось узнать тип треугольника"
    };

    Console.WriteLine(message);
}