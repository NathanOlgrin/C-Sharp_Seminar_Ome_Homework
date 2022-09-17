// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[][] arr) //функция забития "двумерного массива"
{
    for(int i=0;i<arr.Length;i++)
    {
        for(int j=0; j<arr[i].Length;j++)
        {            
            arr[i][j] = new Random().Next(-10,10);
        }
    }
}

void PrintArray(int[][] arr) //функция печати "двумерного массива"
{
   for(int i=0;i<arr.Length;i++)
    {
        for(int j=0; j<arr[i].Length;j++)
        { 
            Console.Write(arr[i][j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void FillArrayResult(int[][] arr, int[] arr_result) // функция забития массива с суммой элементов каждой строки
{
    for(int i=0;i<arr.Length;i++)
    {
        for(int j=0; j<arr[i].Length;j++)
        { 
            arr_result[i]=arr_result[i]+arr[i][j];
        }
    }
}

int FillMinimum(int[] arr_result) //функция поиска наименьшей суммы элементов
{
    int count1 = 1000;
    for(int i=0; i<arr_result.Length;i++)
    {
        if(count1>arr_result[i]) count1 = arr_result[i];
    }
return count1;
}

void PrintNumberColumn(int[] arr_result, int count1) //функция поиска и вывода на экран номера строки с наименьшей суммой элементов
{
    for(int i=0; i<arr_result.Length;i++)
    {
        if(arr_result[i]==count1)
        {
            Console.WriteLine($"Строка с наименьшей суммой элементов - строка №{i+1}");
            break;
        }
    }
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

int[][] array = new int[row][];  //Почти двумерный массив. А вернее, массив массивов :)
for(int i=0;i<row;i++)
{
    array[i] = new int[column];
}

FillArray(array); //вызов функции забития "двумерного массива"
PrintArray(array); //вызов функции печати "двумерного массива"

int[] ArrayResult = new int[row];

FillArrayResult(array, ArrayResult); //забитие массива с суммой элементов каждой строки
Console.WriteLine("");

int count = FillMinimum(ArrayResult); //объявление счетчика минимума

PrintNumberColumn(ArrayResult, count); //вызов функции поиска и вывода на экран номера строки с наименьшей суммой элементов