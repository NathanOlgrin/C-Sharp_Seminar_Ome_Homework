//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string str = Console.ReadLine();
string str1 = string.Empty;
for (int i=0; i<str.Length; i++)
{
    str1 = str[i]+str1;
}
if (str==str1)
{
    Console.WriteLine("Введенное число - палиндром");
}
else
{
    Console.WriteLine("Введенное число - не палиндром");
}
