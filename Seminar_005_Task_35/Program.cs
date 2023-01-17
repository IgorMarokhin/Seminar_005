// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите
// количество элементов массива, значения которых лежат в отрезке [10,99].

int[] array = GetRandomArray(123, -100, 150);
Console.WriteLine(String.Join(" ", array));
Console.Write("Количество элементов отрезка [10,99] ->");
Console.WriteLine(SumNeedNuber(array));

////////////////////////////////////////////////

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

int SumNeedNuber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] >= 10) && (arr[i] <= 99))
            count++;
    }
    return count;
}