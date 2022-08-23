Console.WriteLine("Ведите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
int b = int.Parse(Console.ReadLine());

if(a>b)
{
    Console.Write("Больше число ");
    Console.Write(a);
}
else if (a<b)
{
    Console.Write("Больше число ");
    Console.Write(b);
}
else
{
    Console.Write("Числа равны");
}