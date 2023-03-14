/*
 Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */
//опять создам класс Point2D
using task43;
double getDouble(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}
StraightLine readStraightLineFromKeyboard(string msg)
{
    Console.WriteLine(msg);
    double k = getDouble("Введите коэффициент k: ");
    double b = getDouble("Введите коэффициент b: ");
    return new StraightLine(k, b);
}
StraightLine
    l1 = readStraightLineFromKeyboard("Введите коэффициенты для первой прямой: "),
    l2 = readStraightLineFromKeyboard("Введите коэффициенты для второй прямой: ");
try
{
    Console.WriteLine($"Точка пересечения {l1.getIntersectionPoint(l2)}");
}
catch(NoInterSectionPointException e)
{
    Console.WriteLine(e.getMessage());
}
