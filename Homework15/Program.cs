// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int convert_char_to_int(char ch)
{
    int x = ch - '0';
    return x;
}

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

int summ = 0;
for (int i=0; i<number.Length; i++)
{
    summ = summ + convert_char_to_int(number[i]);
}

Console.Write("Сумма цифр в числе равна: ");
Console.WriteLine(summ);