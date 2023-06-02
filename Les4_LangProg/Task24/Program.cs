
int Insert()
{
    Console.Write("Insert digit: ");
    int d = Convert.ToInt32(Console.ReadLine());
    return d;
}
void Arifm(int d)
{
    if (d > 1)
    {
        int arif = 0;
        for (int i = 1; i <= d; i++)
        {
            arif += i;
        }
        Console.WriteLine(arif);
    }
    else { Console.WriteLine("Error"); }
}
Arifm(Insert());
