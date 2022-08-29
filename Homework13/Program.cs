// Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга
string int_to_string(int int1)
{
    return int1.ToString();
}

int char_to_int(char ch)
{
    int x = ch - '0';
    return x;
}

Console.WriteLine("Введите радиус круга: ");
int r = int.Parse(Console.ReadLine());

double surface = Math.PI*Math.Pow(r,2);

string str = int_to_string(Convert.ToInt32(surface));

int max = 0;
for(int i=0; i<str.Length;i++)
{
    if(max<char_to_int(str[i]))
    {
        max = char_to_int(str[i]);
    }
}

Console.Write("Максимальная цифра в полученном округленном значении площади круга: ");
Console.Write(max);

