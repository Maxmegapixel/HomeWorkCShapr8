// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] MassFirst = GetArray(2, 2, 2, 10, 99);
StringInput("массив: ");
PrintArray(MassFirst);



void StringInput(string text) => Console.WriteLine(text);


// Создание массива
int[,,] GetArray(int row, int col, int dep, int minValue, int maxValue)
{
    
    int[,,] result = new int[row, col, dep];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < dep; k++)
            {
                int randomNumber;
                do
                {
                    randomNumber = new Random().Next(minValue, maxValue + 1);
                } while (ArrayContains(result, randomNumber));
                result[i, j, k] = randomNumber;
            }
        }
    }
    return result;
}
bool ArrayContains(int[,,] array, int value)
{
    foreach (int element in array)
    {
        if (element == value)
        {
            return true;
        }
    }
    return false;
}
// Печать массива
void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}