// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double sqr(int a, int b)
{
    return(Math.Pow(a-b, 2));
}

Console.WriteLine("Ввод координат первой точки:");
Console.WriteLine("Введите X: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ввод координат второй точки:");
Console.WriteLine("Введите X: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine("Расстояние между точками: ");
double distance = Math.Sqrt(sqrt(x1,x2)+sqrt(y1,y2)+sqrt(z1,z2));
Console.WriteLine("{0:F2}", distance);