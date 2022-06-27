/*
// Неверное решение
Console.WriteLine("Введите число не более 1000");
int a = Convert.ToInt32(Console.ReadLine());
void ThirdNumber(int a)
{
    if(a < 100)
    {
        Console.WriteLine("В введенном числе отсутствует третье число");
    }
    if(a>100 & a<999)
    {
        int f = a % 10;
        Console.WriteLine("В числе пристутствует третье и число и это " + f);
    }
    if(a>1000 & a<9999)
    {
        int f = a % 100;
        f = f / 10;
        Console.WriteLine("В числе пристутствует третье и число и это " + f);
    }
    if(a>10000)
    {
        int f = a % 1000;
        f = f / 100;
        Console.WriteLine("В числе пристутствует третье и число и это " + f);
    }
}
ThirdNumber(a);
*/

Console.WriteLine("Введите число.");
int a = Convert.ToInt32(Console.ReadLine());

int ThirdNumber()
{
    if(a<0)
    {
        a = a * -1;
    }
    if(a<100)
    {
        Console.WriteLine("Третье число отсутствует");
    }
    if(a>=100)
    {
        while(a>1000)
        a = a/10;
    }
    int Third = a % 10;
    Console.WriteLine("Третье число - " + Third);
    return Third;
}
ThirdNumber();