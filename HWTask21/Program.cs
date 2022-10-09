// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите точку x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int argx1, int argy1, int argz1, int argx2, int argy2,int argz2)
{
    double result = Math.Sqrt(Math.Pow((argx2 - argx1), 2) + Math.Pow((argy2 - argy1), 2) + Math.Pow((argz2 - argz1), 2));
    return result; 
}
double length = Math.Round(Distance(x1, x2, y1, y2, z1, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(length);