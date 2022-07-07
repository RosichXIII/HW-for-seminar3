//Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.

void DZ4()
{
    Console.WriteLine("Задайте длину массива");
    int[] array = new int[Convert.ToInt32(Console.ReadLine())];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = index + 1;
        //Console.Write(array[index] + ", "); -  для проверки
        index++;
    }
    //Console.Write("\b \b" + "\b \b"); -  для проверки
}
DZ4();