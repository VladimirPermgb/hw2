Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 6:
    {
        Console.WriteLine("Да");
        break;
    }
        case 7:
    {
        Console.WriteLine("Да");
        break;
    }
    default: 
    {
        Console.WriteLine("нет");
        break;
    }
}
