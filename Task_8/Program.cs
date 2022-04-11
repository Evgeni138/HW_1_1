int a = 8, b =1;

while(b +1 < a)
{
    if(b % 2 > 0)
    {
        b ++;
    }
    else
    {
        Console.Write($"{b}, ");
        b++;
    }
}
if( a % 2 < 1)
{
    Console.Write(a);
}
else
{
    Console.Write(a - 1);
}