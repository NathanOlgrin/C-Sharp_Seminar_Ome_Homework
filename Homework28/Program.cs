// Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, сумма которого, больше суммы элементов расположенных в четырех "углах" двумерного массива.
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

void FindColumnSum(int[,] arr, int[] ASC) ////arr - array, ASC - ArraySumColumn
{
    for(int j=0; j<arr.GetLength(1);j++)
    {
        int sum=0;
        for(int i=0; i<arr.GetLength(0);i++)
            {
                sum=sum+arr[i,j];
            }
        Console.WriteLine($"Сумма чисел в {j+1}-м столбце равна: {sum}");
        ASC[j]=sum;
        sum=0;
    }
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

int[,] array = new int[row,column];

FillArray(array);
PrintArray(array);

int SummAngles = array[0,0] + array[row-1,column-1] + array[row-1,0] + array[0,column-1];
Console.WriteLine($"Сумма углов массива равна: {SummAngles}");
int[] ArraySumColumn = new int[column];

FindColumnSum(array,ArraySumColumn);

bool count = false;

for(int j=0;j<column;j++)
{
    if(ArraySumColumn[j]>SummAngles)
    {
        count = true;
        break;
    }
}

if(count==false)
{
    Console.Write("Нет");
}
else
{
    Console.Write("Да");
}


