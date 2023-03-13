/*
 Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
 */
int getIntFromKeyboard(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
bool checkExists(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}

int a = getIntFromKeyboard("Введите сторону a: ");
int b = getIntFromKeyboard("Введите сторону b: ");
int c = getIntFromKeyboard("Введите сторону c: ");
Console.WriteLine(checkExists(a, b, c) ? "Существует" : "Не существует");
//if (checkExists(a, b, c))
//{
//    Console.WriteLine("Существует");
//}
//else Console.WriteLine("Не существует");