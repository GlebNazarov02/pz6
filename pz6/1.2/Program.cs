string Dvoi(int n)
{
    string c = "";
    while (n > 0)
    {
        c = n % 2 +c;
        n = n/2;
    }
    return c;
}
Console.WriteLine("chislo");
int ch = int.Parse(Console.ReadLine());
Console.WriteLine(Dvoi(ch));