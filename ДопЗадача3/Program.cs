//Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.

void DZ3()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int digit4Count = 0;
    int digit7Count = 0;
    while (count < number.ToString().Length)
    {
        if (Math.Abs(number)/Convert.ToInt32(Math.Pow (10, count))%10 == 4)
        {
            digit4Count++;
            count++;
        }
        else if (Math.Abs(number)/Convert.ToInt32(Math.Pow (10, count))%10 == 7)
        {
            digit7Count++;
            count++;
        }
        else
        {
            count++;
        }
    }
    if (digit4Count > 0)
    {
        Console.WriteLine("Кол-во четвёрок: " + digit4Count);
    }
    else
    {
        Console.WriteLine("В числе нет четвёрок");
    }
    if (digit7Count > 0)
    {
        Console.WriteLine("Кол-во семёрок: " + digit7Count);
    }
    else
    {
        Console.WriteLine("В числе нет семёрок");
    }
}
DZ3();