Console.WriteLine("Ведите число: ");
int a = int.Parse(Console.ReadLine());

int count = 1;
if(a>0)
{
    while(count<a+1)
    {
        if(count%2==0)
        {
            Console.Write(count);
            Console.Write(" ");
        }
        count++;
    }
}
else
{
    while(count>a-1)
    {
        if(count%2==0)
        {
            Console.Write(count);
            Console.Write(" ");
        }
        count--;
    }
}