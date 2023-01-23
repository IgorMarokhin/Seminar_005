// Задача 34. Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.

int[] array = GetRandomArray(6, 100, 999);
Console.Write($"[{String.Join(", ", array)}]");
int count = CountEvenNumber(array);
Console.WriteLine($" -> [{String.Join(", ", count)}]");

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

int CountEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 1)
            count++;
    }
    return count;
}