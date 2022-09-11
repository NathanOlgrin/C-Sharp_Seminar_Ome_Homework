// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void FillArray(int[,] arr, int line, int col) //arr - array, line - row, col - column
{
     for(int i=0; i<line; i++)
    {
        for(int j=0; j<col;j++)
        {
            
            arr[i,j] = new Random().Next(-10,10);
        }
    }
}

void PrintArray(int[,] arr, int line, int col) //arr - array, line - row, col - column
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

void FindElement(int[,] arr, int ItNmbr) //arr - array, line - row, col - column, ItNmbr - ItemNumber
{
    int count=0;
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {
            count++;
            if(count==ItNmbr)
            {
                 Console.Write("Значение элемента с этим порядковым номером: ");
                Console.Write(arr[i,j]);
                //break;
            }
        }
    }
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

Console.Write("Введите номер элемента: ");
int ItemNumber = int.Parse(Console.ReadLine());

if(ItemNumber<0 || ItemNumber>row*column)
{
    Console.WriteLine("Элемента с таким порядковым номером нет");
}
else
{
    int[,] array = new int[row,column];
    FillArray(array, row, column);
    PrintArray(array, row, column);
    FindElement(array, ItemNumber);
}

