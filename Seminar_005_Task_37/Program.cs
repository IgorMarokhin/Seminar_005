// Задача 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int amount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[amount];
InputArray(array);
int[] newArray = ReleaseArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}] -> [{string.Join(", ", newArray)}]");

////////////////////////////////////////////////
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 11);
}
int[] ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        Console.Write($"{array[i] * array[array.Length - i - 1]} ");
    return array;
}