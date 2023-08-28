﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Mass = GetArray(3, 4, 1, 9);
PrintArray(Mass);
Console.WriteLine("");
RowsDescending(Mass);
PrintArray(Mass);

void RowsDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) ; i++)
    { 
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            if (array[i,j] < array[i, j+1]) (array[i,j], array[i,j+1]) = (array[i,j+1], array[i,j]);
        }
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
