// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] MassFirst = GetArray(3, 3, 3, 10, 20);
StringInput("массив: ");
PrintArray(MassFirst);







void StringInput(string text) => Console.WriteLine(text);


// Создание массива
int[,,] GetArray(int raw, int col, int dep, int minValue, int maxValue)
{

    int next;
    int temp;
    
    int[,,] res = new int[raw, col, dep];
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < dep; k++)
            {
                bool bit = false;
                next = new Random().Next(minValue, maxValue + 1);
                for (int m = 0; m < i; m++)
                {
                    for (int n = 0; n < j; n++)
                    {
                        for (int l = 0; l < k; l++)
                        {
                            temp = res[m, n, l];
                            if (temp == next)
                            {
                                bit = true;
                                break;
                            }
                        }
                    if (bit == true) break;    
                    }
                if (bit == true) break;    
                }
                res[i, j, k] = next;
            }
        }
    }
    return res;
}
// Печать массива
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

