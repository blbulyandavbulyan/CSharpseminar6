﻿/*
 Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 // пример с ошибкой, тут по факту 4 числа больше 0, моя программа выдаёт 4, да и самому можно увидеть что их тут должно быть 4
 */

//видимо эта задача не так интересна тем, кто уже несколько лет пишет программы
//решается элементарно, даже массив для этого не нужен
int getInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int m = getInt("Введите количество чисел: ");
int result = 0;
for(int i = 0; i < m; i++)
{
    if (getInt($"Введите {i + 1} число: ") > 0) result++;
}
Console.WriteLine($"Количество чисел больше 0 = {result}");