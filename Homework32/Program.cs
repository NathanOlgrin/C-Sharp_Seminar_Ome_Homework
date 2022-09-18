// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void FillArray(int[,,] arr) //arr - array
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {            
            for(int k=0; k<arr.GetLength(2);k++)
            {
                arr[i,j,k] = new Random().Next(10,100);
            }
        }
    }
}

void PrintArray(int[,,] arr) //arr - array
{
   for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {
                for(int k=0; k<arr.GetLength(2);k++)
                {
                    Console.Write($"{arr[i,j,k]} ({i},{j},{k}) ");
                }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите длину массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int deep = int.Parse(Console.ReadLine());

int[,,] array = new int[row,column,deep];
FillArray(array);
PrintArray(array);