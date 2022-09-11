// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void FillArray(int[,] arr) //arr - array
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {            
            arr[i,j] = new Random().Next(-10,10);
        }
    }
}

void PrintArray(int[,] arr) //arr - array
{
   for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {
            Console.Write(arr[i,j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void FillAverage(int[,] arr) ////arr - array
{
    double avg=0;
    int count=0;
    for(int j=0;j<arr.GetLength(1);j++)
    {
        for(int i=0; i<arr.GetLength(0);i++)
        {
            avg=avg+arr[i,j];
            count++;
        }
        avg=avg/count;
        Console.WriteLine($"Сумма чисел в {j+1}-ом столбце равна: {Math.Round(avg, 2)}");
        avg=0;
        count=0;
    }
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

int[,] array = new int[row,column];

FillArray(array);
PrintArray(array);
FillAverage(array);

