// Задайте одномерный массив, заполненный случайными числами. 
// Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
// Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.

double find_average(int count, int[] array1)
{
    double avg=0;
    for(int i=0;i<count;i++)
    {
        avg+=array1[i];
    }
    return avg/count;
}


Console.WriteLine("Введите количество чисел в массиве: ");
int quantity = int.Parse(Console.ReadLine());
int[] array = new int[quantity];
int count_even = 0;
int count_uneven = 0;
//Заполнение вводного массива:
Console.WriteLine("Вывод исходного массива: ");
    for (int i=0;i<quantity;i++)
    {
        array[i] = new Random().Next(1,10);
        Console.Write(array[i]);
        Console.Write(" ");
        if(array[i]%2==0)
        {
            count_even++;
        }
        else
        {
            count_uneven++;
        }
    }

// Заполнение массивов с четными и нечетными числами
int[] array_even = new int[count_even];
int[] array_uneven = new int[count_uneven];
count_even = 0;
count_uneven = 0;
for(int i=0;i<quantity;i++)
{
    if(array[i]%2==0)
    {
        array_even[count_even]=array[i];
        count_even++;
    }
    else
    {
        array_uneven[count_uneven]=array[i];
        count_uneven++;
    }
}

// Нахождение ср. арифметических:
double avg_even = find_average(count_even, array_even);
double avg_uneven = find_average(count_uneven, array_uneven);

//Сравнение ср. арифметических:
Console.WriteLine("");
Console.Write("Среднее арифметическое четных чисел: ");
Console.WriteLine(avg_even);
Console.Write("Среднее арифметическое нечетных чисел: ");
Console.WriteLine(avg_uneven);
if(avg_even>avg_uneven)
{
    Console.WriteLine("Среднее арифметическое четных чисел больше среднеарифметического нечетных чисел.");
}
else if(avg_even<avg_uneven)
{
     Console.WriteLine("Среднее арифметическое нечетных чисел больше среднеарифметического четных чисел.");
}
else
{
     Console.WriteLine("Средние арифметические значения равны.");
}