// Задача 33. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

int[] array = GetRandomArray(8, 0, 100);
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
bool result = ChekingUserNumber(num, array);
Console.WriteLine($"{num}; массив {String.Join(", ", array)} -> {(result ? "да" : "нет")}");

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

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
    Console.WriteLine(errorMessage);
    }
}

bool ChekingUserNumber(int num, int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
            return true;
    }
    return false;
}