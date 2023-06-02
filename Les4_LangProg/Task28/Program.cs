int Insert()
{
    Console.Write("Insert digit: ");
    return Convert.ToInt32(Console.ReadLine());
}
int Proiz(int d)
{
    int p = 1;
    for (int i = 1; i <= d; i++)
    {
        p *= i;
    }
    return p;
}
Console.WriteLine(Proiz(Insert()));
