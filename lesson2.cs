// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите двузначное число");
string snumber = Console.ReadLine();
int number = Convert.ToInt32(snumber);
int result = 1;
int count = number % 10;
int result2 = number / 10;

if (snumber.Length == 2)
{

    while (count > 0)
    {
        result = result * result2;
        count = count - 1;
    }
    Console.WriteLine(result);

}
else
{
    Console.WriteLine("Не двузначное число");
}


// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
string snumber = Console.ReadLine();
int number = Convert.ToInt32(snumber);
int result = 0;
int count = snumber.Length;
int result2 = 0;
int mn = 1;
int i = 0;
int j = 1;

while (j < count)
{
    mn = mn * 10;
    j = j + 1;
}

while (i < count)
{
    result2 = number / mn;
    number = number - (result2 * mn);
    result = result + result2;
    i = i + 1;
    mn = mn / 10;
}
Console.Write("Сумма цифр равна: ");
Console.Write(result);


// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void bitArray()

{
	int[] a = new int[8];
	
	for(int i = 0; i < 8; i++)
	{
		a[i] = new Random().Next(0,99);
		Console.Write(a[i] + " ");
	}
}

bitArray();
