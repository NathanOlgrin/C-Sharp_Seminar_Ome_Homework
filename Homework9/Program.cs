int string_to_int(string string1)
{
    int x;
    if(int.TryParse(string1, out x))
    {
        //Console.WriteLine(string1);
    }
    else
    {

    }
    return x;
}

int average(int x, int y, int z)
{
    return (x+y+z)/3;
}

string int_to_string(int int1)
{
    return int1.ToString();
}

Console.Write("Введите первое трёхзначное число: ");
string number1 = Console.ReadLine();
Console.Write("Введите второе трёхзначное число: ");
string number2 = Console.ReadLine();
Console.Write("Введите третье трёхзначное число: ");
string number3 = Console.ReadLine();

int a = string_to_int(number1);
int b = string_to_int(number2);
int c = string_to_int(number3);

int avg = average(a,b,c);

string string_avg = int_to_string(avg);

int min = a;

if (min>b) min = b;
if (min>c) min = c;

string min_number = int_to_string(min);

char last_char_avg = string_avg[2];
char first_char_min = min_number[0];

int last_number_avg = last_char_avg - '0'; // :)
int last_number_min = first_char_min - '0';

if(last_number_avg>last_number_min)
{
    Console.WriteLine("Да");
}
else if(last_number_avg<last_number_min)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Цифры равны");
}