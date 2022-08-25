int Check(string string2)
{
    if(string2.Length<3)
    {
        return 0;
    }
    else
    {
        return 1;
    }
}

Console.Write("Введите трёхзначное число: ");
string string1 = Console.ReadLine();

if(Check(string1)==1)
{
    Console.Write("Третья цифра введенного числа: ");
    char number = string1[2];
    Console.WriteLine(number);
}
else
{
    Console.Write("Третьей цифры нет");
}