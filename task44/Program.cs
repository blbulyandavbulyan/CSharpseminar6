/*
 Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
 */
long[] getFibonaci(int count)
{
    long[] result = new long[count];
    result[0] = 0;
    result[1] = 1;
    for(int i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 1] + result[i - 2];//f(n) = f(n-1) + f(n-2)
    }
    return result;
}
Console.Write("Введите количество чисел фибоначи: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(string.Join(' ', getFibonaci(n)));