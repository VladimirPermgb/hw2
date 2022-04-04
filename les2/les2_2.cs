// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Как сделать рандом вещественных чисел я не понял, подскажите?
Console.WriteLine("Введите количество столбцов");
int stolb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int strok = Convert.ToInt32(Console.ReadLine());
int[,] massiv = new int [stolb, strok];

for (int i = 0; i < stolb; i++)
{
    for (int j = 0; j < strok; j++)
    {
       massiv[i, j] = new Random().Next(-100, 190);
       Console.Write(massiv[i, j] + " ");
    }
    Console.WriteLine();
}



// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите позицию в строке");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию в столбце");
int y = Convert.ToInt32(Console.ReadLine());
int[,] massiv = new int [10, 10];
int rez = -1;

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
       massiv[i, j] = new Random().Next(100, 390);
       Console.Write(massiv[i, j] + " ");

       if (i == x-1 & j == y-1) rez = massiv [i, j];
       
    }
    Console.WriteLine();
}


if (rez == -1) Console.WriteLine("Вне диапазона");
else Console.WriteLine("Значение элемента: " + rez);

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int stolb = 4;
int strok = 4;
int[,] massiv = new int[stolb, strok];
int[] srarifm = new int[stolb];
int sum = 0;

for (int i = 0; i < stolb; i++)
{
    for (int j = 0; j < strok; j++)
    {
        massiv[i, j] = new Random().Next(1, 5);
        Console.Write(massiv[i, j] + " ");
    }
    Console.WriteLine();
}

int c = 0;
for (int i = 0; i < stolb; i++)
{

    for (int j = 0; j < strok; j++)
    {
        srarifm[c] = massiv[j, c] + srarifm[c];
    }
    Console.WriteLine($"Среднее арифметическое столбца {i + 1}: " + srarifm[c]/stolb);
    Console.WriteLine();
    c++;
}

