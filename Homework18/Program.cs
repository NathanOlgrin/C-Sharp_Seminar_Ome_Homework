// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите количество трёхзначных чисел в массиве: ");
int quantity = int.Parse(Console.ReadLine());
int count = 0;
int[] array = new int[quantity];
Console.WriteLine("Вывод массива: ");
    for (int i=0;i<quantity;i++)
    {
        array[i] = new Random().Next(100, 999);
        Console.Write(array[i]);
        Console.Write(" ");
        if(array[i]%2==0)
        {
            count++;
        }
    }
Console.WriteLine("");
Console.Write("Количество четных числе в массиве: ");
Console.WriteLine(count);