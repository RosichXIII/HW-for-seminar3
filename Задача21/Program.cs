//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

void Z21()
{
    double aX = 7;
    double aY = -5;
    double aZ = 0;
    double bX = 1;
    double bY = -1;
    double bZ = 9;
    double distance = Math.Sqrt(Math.Pow((aX-bX), 2) + Math.Pow((aY-bY), 2) + Math.Pow((aZ-bZ), 2));
    Console.WriteLine(Math.Round(distance, 2));
}
Z21();