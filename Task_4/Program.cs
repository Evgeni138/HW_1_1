int a = 2, b = 3, c = 7;
int max = a;

if(a > b)
{
    if(a > c)
        {
            Console.WriteLine($"Максимальное число a = {max}");
        }
    else 
    {
        max = c;
        Console.WriteLine($"Максимальное число c = {max}");
    }
}
else
{
    if(b > c)
    {
        max = b;
        Console.WriteLine($"Максимальное число b = {max}");
    }
    else 
    {
        max = c;
        Console.WriteLine($"Максимальное число c = {max}");
    }
}