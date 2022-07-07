//Напишите программу, который выводит на консоль таблицу умножения от 1 до n, где n задаётся случайно от 2 до 100.

void DZPS8()
{
    Random rnd = new Random();
    int n = rnd.Next(2, 100);
    for (int i=1; i<=10; i++)
    {
        for (int j=1; j<=n; j++)
        {
            Console.WriteLine($"{i}x{j}={i*j}");
        }
        Console.WriteLine();
    }
}
DZPS8();