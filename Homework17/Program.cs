// Напишите программу, которая задаёт массив из 10 элементов, которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них
int[] array = new int[10];
Console.Write("[");
int max=-100;
for(int i=0;i<10;i++)
{
    array[i] = new Random().Next(-10,10);
    if(max<array[i]) max = array[i];
    Console.Write(array[i]);
    if(i!=9)
    {
    Console.Write(" ");
    }
}
Console.WriteLine("]");

Console.Write("Максимальное значение массива: ");
Console.WriteLine(max);
