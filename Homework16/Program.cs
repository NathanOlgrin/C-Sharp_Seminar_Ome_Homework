// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];
Console.Write("[");
for(int i=0;i<8;i++)
{
    array[i] = new Random().Next(1,100);
    Console.Write(array[i]);
    if(i!=7)
    {
    Console.Write(" ");
    }
}
Console.WriteLine("]");

