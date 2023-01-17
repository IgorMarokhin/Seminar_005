// Задача 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

int[] array2 = GetNewArray(array);
Console.WriteLine(String.Join(" ", array2));

/////////////////////////////////////////////

int GetNewArray(int[] arr)
{
    int size = 0;
    if(arr.Length % 2 == 1)
        size = arr.Length / 2 + 1;
    else
        size = arr.Length / 2;
    
    int result = new int[size];
    for(int i = 0; i < size; i++)
    {
        if((arr.Length % 2 == 1) && (i == size - 1))
            result[i] = arr[i];
        else
            result[i] = arr[i] * array[array.Length - i - 1];
    }
    result result;
}