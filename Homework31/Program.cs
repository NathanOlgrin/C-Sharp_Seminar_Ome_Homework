// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void FillMatrix(int[,] arr) //arr - array
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {            
            arr[i,j] = new Random().Next(-10,10);
        }
    }
}

void PrintMatrix(int[,] arr) //arr - array
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

void MultiplicationMatrix(int [,] matr1, int [,] matr2, int [,] matr_result)
{
    for(int i=0; i<matr1.GetLength(0);i++)
    {
        for(int j=0; j<matr2.GetLength(1);j++)
        {
            for(int k=0;k<matr2.GetLength(0);k++)
            {
                matr_result[i,j]+=matr1[i,k]*matr2[k,j];
            }
        }
    }
}

Console.Write("Введите количество строк и столбцов в матрице 1 (одним числом): ");
int row_matrix_1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк и столбцов в матрице 2 (одним числом):");
int row_matrix_2 = int.Parse(Console.ReadLine());

int[,] matrix1 = new int[row_matrix_1,row_matrix_1];
int[,] matrix2 = new int[row_matrix_2,row_matrix_2];
int[,] matrix_result = new int[row_matrix_1,row_matrix_2];

FillMatrix(matrix1);
FillMatrix(matrix2);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrix1);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);

MultiplicationMatrix(matrix1,matrix2, matrix_result);
Console.WriteLine("Результат перемножения матриц:");
PrintMatrix(matrix_result);