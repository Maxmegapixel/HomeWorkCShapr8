// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MassFirst = GetArray(2, 4, 1, 9);
StringInput("Первый массив: ");
PrintArray(MassFirst);

int[,] MassSecond = GetArray(4, 3, 1, 9);
StringInput("Второй массив: ");
PrintArray(MassSecond);

StringInput("Произведение: ");
PrintArray(MatrixProduct(MassFirst, MassSecond));

int[,] MatrixProduct(int[,] first, int[,] second)
{
    if (first.GetLength(1) != second.GetLength(0))   // Количество стлбцов первой матрицы должно быть равно количеству строк второй
    {
        StringInput("Эти матрицы нельзя перемножить!");  
        
    }
    int[,] result = new int[first.GetLength(0), second.GetLength(1)];
    for (int i = 0; i < first.GetLength(0); i++)
    {
        for (int j = 0; j < second.GetLength(1); j++)
        {
            for (int k = 0; k < second.GetLength(0); k++)
            {
                result[i, j] += first[i, k] * second[k, j];
            }
        }
    }
    return result;
}

void StringInput(string text)
{
    Console.WriteLine(text); 
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