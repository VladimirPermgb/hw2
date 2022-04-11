// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int [,] CreateMatrix (int row, int col)
{
    int [,] array = new int [row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j =0; j < col; j++)
        {
            array [i, j] = new Random().Next (10, 99);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
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

int [,] RawSort (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1)-1; j++)
        {
            for (int k= j+1; k<array.GetLength(1); k++) 
            {
                if (array [i,j] > array [i, k]) 
                {
                    int temp = array [i,j];
                    array [i,j] = array [i,k];
                    array [i,k] = temp;
                }
            }
        }
    }
    return array;
}


int row = 3;
int col = 3;
int [,] matrix = CreateMatrix (row,col);
PrintMatrix (matrix);
Console.WriteLine ();
PrintMatrix (RawSort (matrix));

// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int MinSumRaw (int [,] matrix)
{
    int minSum=0;
    int minIndex=0;
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j<matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        Console.WriteLine (sum);
        if (minSum>sum || i==0)
        {
            minSum=sum;
            minIndex=i;
        }
    }
    Console.WriteLine ();
    return minIndex;
}
int row = 3;
int col = 4;
int [,] matrix = CreateMatrix (row,col);
PrintMatrix (matrix);
Console.WriteLine ();
Console.WriteLine (MinSumRaw (matrix));

// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] CreateMass(int row, int col, int layer)
{
    int[,,] array = new int[row, col, layer];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < layer; k++)
            {
                bool flag = true;
                while (flag)
                {
                    flag = false;
                    int kandidat = new Random().Next(10, 99);
                    for (int i1 = 0; i1 < row; i1++)
                    {
                        for (int j1 = 0; j1 < col; j1++)
                        {
                            for (int k1 = 0; k1 < layer; k1++)
                            {
                                if (array[i1, j1, k1] == kandidat) flag = true;

                            }
                        }
                    }
                    if (!flag) array[i, j, k] = kandidat;

                }

            }
        }
    }
    return array;
}

void PrintKub(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}


int row = 3;
int col = 3;
int layer = 3;
int [,,] array123 = CreateMass (row,col, layer);
PrintKub (array123);
