// Задача 32. Напишите программу замены элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот.

int[] array = GetRandomArray(8, 0, 100);
Console.Write($"[{String.Join(", ", array)}]");
ChangeArray(array);
Console.WriteLine($" -> [{String.Join(", ", array)}]");

/////////////////////////////////////////////

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }
    return result;
}

void ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = - array[i];
}