// See https://aka.ms/new-console-template for more information
/*
 Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
 */
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(convertIntToBinary(n));
string convertIntToBinary(int number)
{
    string result = String.Empty;
    for (int i = number; i > 0; i = i / 2)
    {
        int binaryDigit = i % 2;
        result += binaryDigit;
    }
    return string.Join("", result.Reverse());
}