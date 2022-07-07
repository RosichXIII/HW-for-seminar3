//Рассчитать значение y при заданном x по формуле
//y = sin^2 x при x > 0
//y = 1-2sin x^2  в противном случае.

void DZ1()
{
    Console.WriteLine("Введите x (в градусах)");
    double x = Convert.ToDouble(Console.ReadLine());
    double y;
    if (x > 0)
    {
        y = Math.Round(Math.Pow(Math.Sin(x * Math.PI / 180), 2),8);
        Console.WriteLine(y);
    }
    else
    {
        y = 1 - 2*Math.Round(Math.Sin(Math.Pow(x, 2) * Math.PI / 180),8);
        Console.WriteLine(y);
    }
}
DZ1();