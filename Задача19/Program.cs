//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void Z19()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int powMax = number.ToString().Length - 1;
    int count = 0;
    if (number >= 0)
    {
        while (count < number.ToString().Length/2)
        {
            if (number/Convert.ToInt32(Math.Pow(10, powMax))%10 == number/Convert.ToInt32(Math.Pow(10, count))%10)
            {
                count++;
                powMax--;
            }
            else
            {
                count = number.ToString().Length;
            }
        } 
        if (count == number.ToString().Length)
        {
            Console.WriteLine("Не палиндром");
        }
        else
        {
            Console.WriteLine("Палиндром"); 
        }
                      
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }      
}
Z19();