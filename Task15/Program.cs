Console.WriteLine("Введите номер дня недели.");
int a = Convert.ToInt32(Console.ReadLine());

void DaysNumber()
{
    if(a == 1)
    {
        Console.WriteLine("Понедельник.");
    }
    if(a == 2)
    {
        Console.WriteLine("Вторник.");
    }
    if(a == 3)
    {
        Console.WriteLine("Среда.");
    }
    if(a == 4)
    {
        Console.WriteLine("Четверг.");
    }
    if(a == 5)
    {
        Console.WriteLine("Пятница.");
    }
    if(a == 6)
    {
        Console.WriteLine("Суббота.");
    }
    if(a == 7)
    {
        Console.WriteLine("Воскресенье.");
    }
    if(a > 7)
    {
        Console.WriteLine("Сегодня не ваш день и даже не доброе утро, отдохните. С уважением администрация.");
    }
}
DaysNumber();