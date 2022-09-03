// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите количество чисел в массиве: ");
int quantity = int.Parse(Console.ReadLine());
int summ = 0;
int[] array = new int[quantity];
Console.WriteLine("Вывод массива: ");
    for (int i=0;i<quantity;i++)
    {
        array[i] = new Random().Next(0,100);
        Console.Write(array[i]);
        Console.Write(" ");
        if(i%2!=0)
        {
            summ+=array[i];
        }
    }
Console.WriteLine("");
Console.Write("Сумма нечетных числе в массиве: ");
Console.WriteLine(summ);
