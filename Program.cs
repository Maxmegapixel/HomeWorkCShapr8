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
    int i = 0;
    int j = 0;
    int k = 1;
    int val=0;
    do
    {
        switch (val % 4)
        {
            case 0:
                {
                    for (; j < row; j++)
                    {
                        array[i, j] = k;
                        k++;
                    }
                    row--;
                    i++;
                    break;
                }
            case 1:
                {
                    for (; i < col - 1; i++)
                    {
                        array[i, j] = k;
                        k++;
                    }
                    col--;
                    j--;
                    break;
                }
            case 2:
                {
                    for (; j < row; j--)
                    {
                        array[i, j] = k;
                        k++;
                    }
                    row--;
                    i--;
                    break;
                }
            case 3:
                {
                    for (; i < col - 1; i--)
                    {
                        array[i, j] = k;
                        k++;
                    }
                    col--;
                    j++;
                    break;
                }

        }
    val++;

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
            Console.Write($"{mass[i, j]} ");
        }
        Console.WriteLine();
    }
}