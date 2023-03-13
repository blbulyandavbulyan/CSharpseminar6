//Напишите программу которая разворачивает массив
void reverseArray(int[] arr)
{
    for(int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}
int[] generateRandomArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for(int i = 0; i <  length; i++)
    {
        arr[i] = Random.Shared.Next(min, max + 1);
    }
    return arr;
}
int[] arr = generateRandomArray(20, -200, 200);
Console.WriteLine(string.Join(" ", arr));
reverseArray(arr);
Console.WriteLine(string.Join(" ", arr));