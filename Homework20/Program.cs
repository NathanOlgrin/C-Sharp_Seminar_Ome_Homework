// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите количество чисел в массиве: ");
int quantity = int.Parse(Console.ReadLine());
double max = -1000;
double min = 1000;
double[] array = new double[quantity];
Console.WriteLine("Вывод массива: ");
    for (int i=0;i<quantity;i++)
    {
        array[i] = new Random().Next(-1000,1000);
        Console.Write(array[i]);
        Console.Write(" ");
       if(max<array[i]) max = array[i];
       if(min>array[i]) min = array[i];
    }
Console.WriteLine("");
Console.Write("Разница между максимальным и минимальным элементами в массиве: ");
Console.WriteLine(max-min);
