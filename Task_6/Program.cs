int a = -3;

if(a > 0)
{
    if(a % 2 > 0)
    {
        Console.WriteLine($"Число a = {a} - нечетное");
    }
    else
    {
        Console.WriteLine($"Число a = {a} - четное");
    }
}
else
{
    if(a * (-1) % 2 > 0)
    {
        Console.WriteLine($"Число a = {a} - нечетное");
    }
    else
    {
        Console.WriteLine($"Число a = {a} - четное");
    }
}