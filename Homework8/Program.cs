bool Check_for_saturday(int x)
{
    if(x==6)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool Check_for_sunday(int x)
{
    if(x==7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите цифру, обозначающую день недели (от 1 до 7): ");
int day = int.Parse(Console.ReadLine());

if(Check_for_saturday(day)==true)
{
    Console.WriteLine("Сегодня суббота, выходной день");
}
else if(Check_for_sunday(day)==true)
{
    Console.WriteLine("Сегодня воскресенье, выходной день");
}
else
{
    Console.WriteLine("Сегодня рабочий день недели");
}