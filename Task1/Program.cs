// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void ShowArrayInterval (int M, int N)
{
    if (M == N)
    {
        Console.Write (N);
        return;
    }
    Console.Write ($"{M} ");
    ShowArrayInterval (M+1,N);
}

ShowArrayInterval (4,8);