// Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.

void FillArray(int[] arr) //функция заполнения массива
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(1,10);
    }
}

void GoToLeft(int[] arr) // функция смещения массива влево
{
    int temp = arr[0];
    for (int i=1; i<arr.Length-1; i++)
    {
        arr[i-1] = arr[i];
    }
    arr[arr.Length-1] = temp;
}

void GoToRight(int[] arr) //функция смещения массива вправо
{
    int temp = arr[arr.Length-1];
    for(int i=arr.Length-1; i>0;i--)
    {
        arr[i] = arr[i-1];
    }
    arr[0] = temp;
}

Console.Write("Введите количество элементов в массиве: ");
int n = int.Parse(Console.ReadLine());

int[] array = new int[n];

FillArray(array);

Console.WriteLine("Исходный: ");
Console.WriteLine(String.Join(" ", array));

Console.WriteLine("Сдвинуть массив влево или вправо? left/right: ");
string str = Console.ReadLine();
switch(str)
{
    case "left":
    {
        GoToLeft(array);
        Console.WriteLine("Смещенный влево массив: ");
        Console.WriteLine(String.Join(" ", array));
        break;
    } 
    case "right": 
    {
        GoToRight(array);
        Console.WriteLine("Смещенный вправо массив: ");
        Console.WriteLine(String.Join(" ", array));
        break;
    }
}
