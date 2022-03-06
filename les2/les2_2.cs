Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int n1 = number / 100;
int n2 = number - n1 * 100;
int n3 = n2 / 10;

Console.WriteLine(n3);