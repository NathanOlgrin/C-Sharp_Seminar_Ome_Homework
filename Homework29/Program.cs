// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void SortingAnArray(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0);i++)
    {
        for(int j=0;j<arr.GetLength(1)-1; j++)
        {
            for (int k=j+1;k<arr.GetLength(1);k++)
            {
                if(arr[i,k]>arr[i,j])
                {
                    (arr[i,j],arr[i,k])=(arr[i,k], arr[i,j]);
                }
            }
        }
    }
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

int[,] array = new int[row,column];
FillArray(array);
PrintArray(array);
Console.WriteLine("");
SortingAnArray(array);
PrintArray(array);

