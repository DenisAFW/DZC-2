Console.WriteLine("Введите число не более 1000");
int a = Convert.ToInt32(Console.ReadLine());
void ThirdNumber(int a)
{
    if(a < 100)
    {
        Console.WriteLine("В введенном числе отсутствует третье число");
    }
    else
    {
        int f = a % 10;
        Console.WriteLine("В числе пристутствует третье и число и это " + f);
    }
}
ThirdNumber(a);