
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Mass = GetArray(3, 4, 1, 9);
PrintArray(Mass);
Console.WriteLine("");
RowsMinSumm(Mass);


void RowsMinSumm(int[,] array)
{
    int[] summ = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0) ; i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ[i] += array[i, j];
        }
    }
    int MinIndex = 0;
    int MinSumm = summ[0];
    for (int i = 0; i < summ.Length; i++)
    {
        if (MinSumm > summ[i] ) 
        {
            MinSumm = summ[i];
            MinIndex = i;
        }
    }
    Console.WriteLine("Строка с наименьшей суммой элементов: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"{array[MinIndex, i]} ");
    }
} 
// Создание массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}
// Печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

