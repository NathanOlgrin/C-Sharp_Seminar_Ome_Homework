// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void FillArray(double[,] arr, int line, int col) //arr - array, line - row, col - column
{
    Random r = new Random();
    for(int i=0; i<line; i++)
    {
        for(int j=0; j<col;j++)
        {
            
            arr[i,j] = Convert.ToDouble(r.Next(-100,100))/10.0;
        }
    }
}

void PrintArray(double[,] arr, int line, int col) //arr - array
{
    for(int i=0; i<line; i++)
    {
        for(int j=0; j<col;j++)
        {
            Console.Write(arr[i,j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

double[,] array = new double[row,column];

FillArray(array, row, column);
PrintArray(array, row, column);
