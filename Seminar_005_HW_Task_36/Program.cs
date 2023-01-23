// Задача 36. Создайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

int[] array = GetRandomArray(6, 0, 99);
Console.Write($"[{String.Join(", ", array)}]");
int sum = SumOddNumbers(array);
Console.WriteLine($" -> [{String.Join(", ", sum)}]");

/////////////////////////////////////////////

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }
    return result;
}

int SumOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 1)
            sum = sum + array[i];
    }
    return sum;
}