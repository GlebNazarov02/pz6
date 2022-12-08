void Treug(int a,int b,int c)
{
    if ((a + b > c) & (b + c > a) & (a + c > b))
    {
        Console.Write("+");
    }
    else
    {
        Console.Write("-");
    }
}   

int a1 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int c1 = int.Parse(Console.ReadLine());
Treug(a1,b1,c1);