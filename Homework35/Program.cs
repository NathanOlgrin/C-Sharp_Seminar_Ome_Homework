// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
int recursion(int i, int j)
{
    if(i>j)
    {
        if(i==j)
        {
            return i;
        }
        return i+recursion(i-1,j);
    }
    else
    {
        if(i==j)
        {
            return i;
        }
        return i +recursion(i+1,j);
    }
}

Console.WriteLine("Введите число M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(recursion(m,n));