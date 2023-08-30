// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

PrintArray(SpiralArray(4, 4));

int[,] SpiralArray(int row, int col)
{
    int[,] array = new int[row, col];
    int rowStart = 0;
    int colStart = 0;
    int k = 1;
    int rowEnd = row - 1;
    int colEnd = col - 1;
    do
    {

        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = k++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = k++;
        }
        colEnd--;

        if (rowStart <= rowEnd)
        {
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = k++;
            }
            rowEnd--;
        }

        if (colStart <= colEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = k++;
            }
            colStart++;

        }
    }
    while (row * col > k);

    return array;
}



// Печать массива
void PrintArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i, j]:00} ");
        }
        Console.WriteLine();
    }
}