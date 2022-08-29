// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

if (n>0)
{
    for(int i=1; i<n+1; i++)
    {
        Console.Write(Math.Pow(i, 3));
        Console.Write(" ");
    }
}
else
{
    for (int i=1; i>n-1; i--)
    {
        Console.Write(Math.Pow(i, 3));
        Console.Write(" ");
    }
}