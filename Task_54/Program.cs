/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] arr = GetArray(5, 5, 1,9);
PrintArray(arr);
Console.WriteLine();
SortedMin(arr);
PrintArray(arr);
//PrintArray(arr);
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
void SortedMin(int[,] inArray)
{
    for (int a = 0; a < inArray.GetLength(0); a++)
    {
        for (int i = 0; i < inArray.GetLength(1) - 1; i++)
        {
            for (int j = 0; j < inArray.GetLength(1) - 1 - i; j++)
            {
                if (inArray[a, j] < inArray[a, j + 1])
                {
                    int tmp = inArray[a, j];
                    inArray[a, j] = inArray[a, j + 1];
                    inArray[a, j + 1] = tmp;
                }
            }
        }
    }
}

