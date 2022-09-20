// Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
Console.WriteLine("Hello, World!");
int recursion(int i, int j)
{
    if(j==0)
    {
        return i;
    }
    else
    {
        return recursion(j, i%j);
    }
}

Console.WriteLine("Введите число M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(recursion(m,n));