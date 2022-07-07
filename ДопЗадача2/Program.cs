//Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.

void DZ2()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int sum = 0;
    while (count < number.ToString().Length)
    {
        sum += number%10;
        count++;
        number = number/10;
    }
    if (sum%3 == 0)
    {
        Console.WriteLine("Сумма цифр кратна трём");
    }
    else
    {
        Console.WriteLine("Сумма цифр не кратна трём");
    }
}
DZ2();