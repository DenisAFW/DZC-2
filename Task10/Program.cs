int FindSecondNumber()
{
    int r = new Random().Next(100, 999);
    Console.WriteLine("Current random number is " + r);
    
    int dec = r / 10;
    int sec = dec % 10;
    Console.WriteLine("Second number is " + sec);
    return sec;
}
FindSecondNumber();