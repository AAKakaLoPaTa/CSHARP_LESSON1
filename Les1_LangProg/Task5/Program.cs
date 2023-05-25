Console.Write("Insert digit: ");
int d = Convert.ToInt32(Console.ReadLine());
for (int i = -d; i <= d; i++)
{
    if (i == -d)
    {
        Console.Write("\"");
    }
    if (i != -d)
    {
        Console.Write(", ");
    }
    Console.Write(i);
    if (i == d)
    {
        Console.WriteLine("\"");
    }
}
