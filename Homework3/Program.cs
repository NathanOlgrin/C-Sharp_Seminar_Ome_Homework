Console.WriteLine("Ведите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;

Console.Write("Наибольшее число ");
Console.Write(max);