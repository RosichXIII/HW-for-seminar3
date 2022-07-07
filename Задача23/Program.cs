//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void Z23()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        Console.Write(Math.Pow(count, 3) + ", ");
        count++;
    }    
    Console.Write("\b \b" + "\b \b");
}
Z23();