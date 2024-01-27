// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

void ShowReversArray(int[] arr, int i)
{
    if (i == 0)
    {
        Console.Write($"{arr[i]}");
        return;
    }
    Console.Write($"{arr[i]} ");
    ShowReversArray(arr, i - 1);

}

int[] array = { 1, 2, 5, 0, 10, 34 };

ShowReversArray(array, array.Length - 1);
